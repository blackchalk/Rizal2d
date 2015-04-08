using UnityEngine;
using System.Collections;

public class PortalHereAct1S3Back : MonoBehaviour {

		
		void OnTriggerEnter2D(Collider2D col)
		{
			if (col.gameObject.tag == "Player") 
			{
				
				Application.LoadLevel("Act 1 Scene 2");
				
				Debug.Log("You have walked into a portal");
			}
			
			
		}
		
		
	}