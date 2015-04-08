using UnityEngine;
using System.Collections;

public class Act1S2toS1Portal : MonoBehaviour {


		void OnTriggerEnter2D(Collider2D col)
		{
			if (col.gameObject.tag == "Player") 
			{
				
				Application.LoadLevel("Act 1 Scene 2A");
				
				Debug.Log("You have walked into a portal");
			}
			
			
		}
		
		
	}
