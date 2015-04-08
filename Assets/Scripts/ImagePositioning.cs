using UnityEngine;
using System.Collections;

public class ImagePositioning : MonoBehaviour {

	public Texture2D splashLogo; // the logo to splash;
	private Camera oldCam;

	public enum LogoPositioning
	{
		Centered,
		Stretched
	}
	public LogoPositioning logoPositioning;

	private Rect splashLogoPos = new Rect();

	// Use this for initialization
	void Start () {
		oldCam = Camera.main;
		if (logoPositioning == LogoPositioning.Centered)
		{
			splashLogoPos.x = (Screen.width * 0.5f) - (splashLogo.width * 0.5f);
			splashLogoPos.y = (Screen.height * 0.5f) - (splashLogo.height * 0.5f);
			
			splashLogoPos.width = splashLogo.width;
			splashLogoPos.height = splashLogo.height;
		}
		else
		{
			splashLogoPos.x = 0;
			splashLogoPos.y = 0;
			
			splashLogoPos.width = Screen.width;
			splashLogoPos.height = Screen.height;
		}

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
