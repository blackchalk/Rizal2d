using UnityEngine;
using System.Collections;

public class screenOrientation : MonoBehaviour {

	// Use this for initialization
	void Start () {
//		DeviceOrientation orientation = Input.deviceOrientation;
//		if (orientation == DeviceOrientation.LandscapeLeft)
//		{
//			Screen.orientation = ScreenOrientation.LandscapeLeft;
//		}
//		else if (orientation == DeviceOrientation.LandscapeRight)
//		{
//			Screen.orientation = ScreenOrientation.LandscapeRight;
//		}


	}
	
	// Update is called once per frame
	void Update () {

		DeviceOrientation orientation = Input.deviceOrientation;
		if (orientation == DeviceOrientation.LandscapeLeft)
		{
			Screen.orientation = ScreenOrientation.LandscapeLeft;
		}
		else if (orientation == DeviceOrientation.LandscapeRight)
		{
			Screen.orientation = ScreenOrientation.LandscapeRight;
		}
		

	}
}
