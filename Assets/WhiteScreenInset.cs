using UnityEngine;
using System.Collections;

public class WhiteScreenInset : MonoBehaviour {

	// Use this for initialization
	void Start () {
		guiTexture.pixelInset = new Rect(0,0,Screen.width,Screen.height);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
