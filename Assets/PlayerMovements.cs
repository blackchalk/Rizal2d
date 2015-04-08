
using UnityEngine;
using System.Collections;
//[RequireComponent(AudioSource)]
public class PlayerMovements : MonoBehaviour {

	public Sprite[] left;
	public Sprite[] right;
	public Sprite[] down;
	public Sprite[] up;
	public Sprite[] upLeft;
	public Sprite[] upRight;
	public Sprite[] downLeft;
	public Sprite[] downRight;
	public float framesPerSecond;
	public SpriteRenderer nyanAnimator;

	private GUITexture gui;
	private MPJoyStick joy;

	public Vector2 upLeftDirection = new Vector2 (-1f, 1f);
	public Vector2 downRightDirection = new Vector2 (1f, -1f);
	public Vector2 movementUpLeft;
	public Vector2 movementDownRight;

	public float x1;
	public float y1;
	public float moveSpeed = 5f;

	//Animations
	public bool animLeft = false;
	public bool animRight = false;
	public bool animUp = false;
	public bool animDown = false;
	public bool animUpRight = false;
	public bool animUpLeft = false;
	public bool animDownLeft = false;
	public bool animDownRight = false;


	//Directions
	public bool moveLeft = false;
	public bool moveRight = false;
	public bool moveUp = false;
	public bool moveDown = false;
	public bool moveUpLeft = false;
	public bool moveUpRight = false;
	public bool moveDownLeft = false;
	public bool moveDownRight = false;

	//Last Direction that the user headed
	public bool lastLeft = false;
	public bool lastRight = false;
	public bool lastUp = false;
	public bool lastDown = false;
	public bool lastUpleft = false;
	public bool lastUpRight = false;
	public bool lastDownLeft = false;
	public bool lastDownRight = false;

	public bool stop = false;
	public bool stops = true;

	// Use this for initialization
	void Start () {
		joy = GameObject.Find ("Single Joystick").GetComponent <MPJoyStick>();	
	}

	void baseSprite(){
		if(lastLeft){
			nyanAnimator.sprite = left [1];
		}

		if(lastRight){
			nyanAnimator.sprite = right [1];
		}

		if(lastUp){
			nyanAnimator.sprite = up [1];
		}

		if(lastDown){
			nyanAnimator.sprite = down [1];
		}

		if(lastUpRight){
			nyanAnimator.sprite = upRight [1];
		}

		if(lastUpleft){
			nyanAnimator.sprite = upLeft [1];
		}

		if(lastDownLeft){
			nyanAnimator.sprite = downLeft [1];
		}

		if(lastDownRight){
			nyanAnimator.sprite = downRight [1];
		}

	}

	public void release(){
		stops = true;
	}

	public void stopMovements(){
		rigidbody2D.velocity = Vector2.zero;
		stops = false;
		//joy.x = 0;
		//joy.y = 0;

		animLeft = false;
		animRight = false;
		animUp = false;
		animDown = false;
		animUpRight = false;
		animUpLeft = false;
		animDownLeft = false;
		animDownRight = false;

		moveLeft = false;
		moveRight = false;
		moveUp = false;
		moveDown = false;
		moveUpLeft = false;
		moveUpRight = false;
		moveDownLeft = false;
		moveDownRight = false;
	}

	// Update is called once per frame
	void Update () {
				movementUpLeft = new Vector2 (upLeftDirection.x * moveSpeed, upLeftDirection.y * moveSpeed);
				movementDownRight = new Vector2 (downRightDirection.x * moveSpeed, downRightDirection.y * moveSpeed);


				x1 = joy.x;
				y1 = joy.y;
		if(stops){
			if ((x1 >= -1f && x1 < 0f) && (y1 >= -0.4f && y1 <= 0.4f)) {

				moveLeft = true;
				animLeft = true;

				lastLeft = true;
				lastRight = false;
				lastUp = false;
				lastDown = false;
				lastUpleft = false;
				lastUpRight = false;
				lastDownLeft = false;
				lastDownRight = false;

			} else {
				moveLeft = false;
				animLeft = false;
			}

			if ((x1 > 0f && x1 <= 1f) && (y1 >= -0.4f && y1 <= 0.4f)) {

				moveRight = true;
				animRight = true;

				lastLeft = false;
				lastRight = true;
				lastUp = false;
				lastDown = false;
				lastUpleft = false;
				lastUpRight = false;
				lastDownLeft = false;
				lastDownRight = false;

			} else {
				moveRight = false;
				animRight = false;

			}

			if ((x1 >= -0.4f && x1 <= 0.4f) && (y1 > 0f && y1 <= 1f)) {

				moveUp = true;
				animUp = true;

				lastLeft = false;
				lastRight = false;
				lastUp = true;
				lastDown = false;
				lastUpleft = false;
				lastUpRight = false;
				lastDownLeft = false;
				lastDownRight = false;

			} else {
				moveUp = false;
				animUp = false;
			}

			if ((x1 >= -0.4f && x1 <= 0.4f) && (y1 >= -1f && y1 < 0f)) {

				moveDown = true;
				animDown = true;

				lastLeft = false;
				lastRight = false;
				lastUp = false;
				lastDown = true;
				lastUpleft = false;
				lastUpRight = false;
				lastDownLeft = false;
				lastDownRight = false;

			} else {
				moveDown = false;
				animDown = false;
			}

			//upRight
			if ((x1 > 0.4f && x1 <= 1f) && (y1 > 0.4f && y1 <= 1f)) {

				moveUpRight = true;
				animUpRight = true;

				lastLeft = false;
				lastRight = false;
				lastUp = false;
				lastDown = false;
				lastUpleft = false;
				lastUpRight = true;
				lastDownLeft = false;
				lastDownRight = false;
			
			} else {
				moveUpRight = false;
				animUpRight = false;
			}

			//upLeft

			if ((x1 < -0.4f && x1 >= -1f) && (y1 > 0.4f && y1 <= 1f)) {

				moveUpLeft = true;
				animUpLeft = true;

				lastLeft = false;
				lastRight = false;
				lastUp = false;
				lastDown = false;
				lastUpleft = true;
				lastUpRight = false;
				lastDownLeft = false;
				lastDownRight = false;

			} else {
				moveUpLeft = false;
				animUpLeft = false;
			}

			//downRight

			if ((x1 > 0.4f && x1 <= 1f) && (y1 < -0.4f && y1 >= -1f)) {

				moveDownRight = true;
				animDownRight = true;

				lastLeft = false;
				lastRight = false;
				lastUp = false;
				lastDown = false;
				lastUpleft = false;
				lastUpRight = false;
				lastDownLeft = false;
				lastDownRight = true;

			} else {
				moveDownRight = false;
				animDownRight = false;
			}

			//downLeft
			if ((x1 < -0.4f && x1 >= -1f) && (y1 < -0.4f && y1 >= -1f)) {

				moveDownLeft = true;
				animDownLeft = true;

				lastLeft = false;
				lastRight = false;
				lastUp = false;
				lastDown = false;
				lastUpleft = false;
				lastUpRight = false;
				lastDownLeft = true;
				lastDownRight = false;

			} else {
				moveDownLeft = false;
				animDownLeft = false;
			}
			
			if (x1 == 0f && y1 == 0f) {

				stop = true;
				baseSprite ();

			} else {
				stop = false;

			}
		}
	}

	void FixedUpdate(){
//		Debug.Log (""+rigidbody2D.velocity);

		if(moveLeft){
			rigidbody2D.velocity = -Vector2.right * moveSpeed;

			if(animLeft){
				
				nyanAnimator = renderer as SpriteRenderer;
				
				int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
				index = index % left.Length;
				nyanAnimator.sprite = left [index];
				
			}



		}

		if(moveRight){
			
			rigidbody2D.velocity = Vector2.right * moveSpeed;

			if(animRight){

				nyanAnimator = renderer as SpriteRenderer;
				
				int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
				index = index % right.Length;
				nyanAnimator.sprite = right [index];
			}
		}

		if(moveUp){
			
			rigidbody2D.velocity = Vector2.up * moveSpeed;

			if(animUp){

				nyanAnimator = renderer as SpriteRenderer;
				
				int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
				index = index % up.Length;
				nyanAnimator.sprite = up [index];
			}
		}

		if(moveDown){
			
			rigidbody2D.velocity = -Vector2.up * moveSpeed;

			if(animDown){

				nyanAnimator = renderer as SpriteRenderer;
				
				int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
				index = index % down.Length;
				nyanAnimator.sprite = down [index];
			}
		}

		if(moveUpLeft){
			
			rigidbody2D.velocity = movementUpLeft;

			if(animUpLeft){
				
				nyanAnimator = renderer as SpriteRenderer;
				
				int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
				index = index % upLeft.Length;
				nyanAnimator.sprite = upLeft [index];
				
			}

		}

		if(moveUpRight){
			
			rigidbody2D.velocity = Vector2.one * moveSpeed;

			if(animUpRight){
				
				nyanAnimator = renderer as SpriteRenderer;
				
				int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
				index = index % upRight.Length;
				nyanAnimator.sprite = upRight [index];
			}

		}

		if(moveDownLeft){
			
			rigidbody2D.velocity = -Vector2.one * moveSpeed;

			if(animDownLeft){
				
				nyanAnimator = renderer as SpriteRenderer;
				
				int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
				index = index % downLeft.Length;
				nyanAnimator.sprite = downLeft [index];
				
			}
		}

		if(moveDownRight){
			
			rigidbody2D.velocity = movementDownRight;

			if(animDownRight){
				
				nyanAnimator = renderer as SpriteRenderer;
				
				int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
				index = index % downRight.Length;
				nyanAnimator.sprite = downRight [index];
				
			}
		}

		if(stop){
			rigidbody2D.velocity = Vector2.zero;
		}
	}

//	void OnGUI(){
//
//		GUI.Label (new Rect (0, 0, 700, 20), "x: " +x1+ " y: " +y1+ " -> x and y values" );
//		GUI.Label (new Rect (0, 15, 700, 20), "left: " +moveLeft+ " right: " +moveRight);
//		GUI.Label (new Rect (0, 30, 700, 20), "up: " +moveUp+ " down: " +moveDown);
//		GUI.Label (new Rect (0, 45, 700, 20), "upLeft: " +moveUpLeft+ " upRight: " +moveUpRight);
//		GUI.Label (new Rect (0, 60, 700, 20), "downLeft: " +moveDownLeft+ " downRight: " +moveDownRight);
//		GUI.Label (new Rect (0, 75, 700, 20), "RightA: " +animRight+ " LeftA: " +animLeft);
//		GUI.Label (new Rect (0, 90, 700, 20), "DownA: " +animDown+ " UpA: " +animUp);
//
//	}
}
