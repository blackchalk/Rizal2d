using UnityEngine;
using System.Collections;

public class PortalHereAct1S2: MonoBehaviour {
	
	
	
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player") 
		{
			
			Application.LoadLevel("Act 1 Scene 3");
			
			Debug.Log("Entering Scene 3");
		}
		
		
	}
	
	
}