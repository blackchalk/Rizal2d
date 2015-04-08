using UnityEngine;
using System;
using System.Collections.Generic;
using System.Collections;

//    NotificationCenter is used for handling messages between GameObjects.
//    GameObjects can register to receive specific notifications.  When another objects sends a notification of that type, all GameObjects that registered for it and implement the appropriate message will receive that notification.
//    Observing GameObjects must register to receive notifications with the AddObserver function, and pass their selves, and the name of the notification.  Observing GameObjects can also unregister themselves with the RemoveObserver function.  GameObjects must request to receive and remove notification types on a type by type basis.
//    Posting notifications is done by creating a Notification object and passing it to PostNotification.  All receiving GameObjects will accept that Notification object.  The Notification object contains the sender, the notification type name, and an option hashtable containing data.
//    To use NotificationCenter, either create and manage a unique instance of it somewhere, or use the static NotificationCenter.

public class NotificationCentre : MonoBehaviour
{
	
	private static NotificationCentre instance;
	
	
	Hashtable notifications = new Hashtable();
	
	public static NotificationCentre Instance
	{
		get
		{
			if (instance == null)
			{
				instance = new GameObject("NotificationCentre").AddComponent<NotificationCentre> ();
			}
			
			return instance;
		}
	}
	
	public void OnApplicationQuit ()
	{
		instance = null;
	}
	
	
	public static void AddObserver(Component observer, String name)
	{
		if(name == null || name == "")
		{
			Debug.Log ("Null name specificed for notification in AddObserver.");
			return;
		}
		if(Instance.notifications.Contains(name) == false)
		{
			Instance.notifications[name] = new ArrayList();
		}
		
		ArrayList notifyList = (ArrayList)Instance.notifications[name];
		
		if(!notifyList.Contains(observer))
		{
			notifyList.Add(observer);
		}
		
	}
	
	
	public static void RemoveObserver(Component observer, String name)
	{
		ArrayList notifyList = (ArrayList)Instance.notifications[name];
		
		if(notifyList != null)
		{
			if(notifyList.Contains(observer))
			{
				notifyList.Remove(observer);
			}
			if(notifyList.Count == 0)
			{
				Instance.notifications.Remove(name);
			}
		}
	}
	
	public static void PostNotification (Component aSender, String aName)
	{
		PostNotification(aSender, aName, null);
	}
	
	public static void PostNotification (Component aSender, String aName, Hashtable aData)
	{
		PostNotification(new Notification(aSender, aName, aData));
	}
	
	private static void PostNotification (Notification aNotification)
	{
		if(aNotification.name == null || aNotification.name == "")
		{
			Debug.Log("Null name sent to PostNotification.");
			return;
		}
		
		ArrayList notifyList = (ArrayList)Instance.notifications[aNotification.name];
		
		if(notifyList == null)
		{
			Debug.Log("Notify list not found in PostNotification.");
			return;
		}
		
		ArrayList observersToRemove = new ArrayList();
		
		foreach( Component observer in notifyList)
		{
			if(!observer)
			{
				observersToRemove.Add(observer);
			}
			else
			{
				observer.SendMessage(aNotification.name, aNotification, SendMessageOptions.DontRequireReceiver);
			}
		}
		
		foreach( object observer in observersToRemove)
		{
			notifyList.Remove(observer);
		}
	}
}

// The Notification class is the object that is sent to receiving objects of a notification type.
// This class contains the sending GameObject, the name of the notification, and optionally a hashtable containing data.
class Notification {
	
	public Component sender;
	public String name;
	public Hashtable data;
	
	public Notification (Component aSender, String aName ) 
	{ 
		sender = aSender; 
		name = aName; 
	}
	
	public Notification (Component aSender, String aName, Hashtable aData)
	{ 
		sender = aSender; 
		name = aName; 
		data = aData; 
	}
}