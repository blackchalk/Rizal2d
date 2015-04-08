using UnityEngine;
using System.Collections;

public class Act1S1toS2Portal: MonoBehaviour {

	public GameObject other;


	
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player") 
		{
		

			Application.LoadLevel("Act 1 Scene 2B");
		
			Debug.Log("You have walked into a portal");
		}
		
		
	}
	

}


	


