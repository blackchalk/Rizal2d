using UnityEngine;
using System.Collections;

//[RequireComponent(typeof (Rigidbody2D))]
//[RequireComponent(typeof(BoxCollider2D))]
public class TouchControlsNEW : MonoBehaviour {

	public Sprite[] left;
	public Sprite[] right;
	public Sprite[] down;
	public Sprite[] up;
	public Sprite[] upleft;
	public Sprite[] upright;
	public Sprite[] downleft;
	public Sprite[] downright;
	public float framesPerSecond;
	public SpriteRenderer nyanAnimator;

	//for additional diagonal movements
	public Vector2 upLeftDirection = new Vector2 (-1, 1);
	public Vector2 downRightDirection = new Vector2 (1, -1);
	public Vector2 speed = new Vector2 (5, 5);
	public Vector2 movementUpLeft;
	public Vector2 movementDownRight;

	// GUI textures
	public GUITexture guiLeft;
	public GUITexture guiRight;
	public GUITexture guiUp;
	public GUITexture guiDown;
	public GUITexture guiJump;
	public GUITexture guiUpRight;
	public GUITexture guiUpLeft;
	public GUITexture guiDownLeft;
	public GUITexture guiDownRight;
	
	// Movement variables
	public float moveSpeed = 5f;
	public float jumpForce = 50f;
	public float maxJumpVelocity = 2f;
	
	// Movement flags
	private bool moveLeft, moveRight, moveUp, moveDown, moveUpRight, moveUpLeft,
				moveDownLeft, moveDownRight, doJump, animLeft, 
				animRight, animDown, animUp = false;
	
	// Update is called once per frame

	public void StopMove(){
		moveSpeed = 0f;
	}

	public void Go(){

		moveSpeed = 5f;
	}

	public void StopAnim(){
		framesPerSecond = 0f;
	}

	public void GoAnim(){
		framesPerSecond = 5f;
	}

	void Update () {

		movementUpLeft = new Vector2(upLeftDirection.x * moveSpeed, upLeftDirection.y * moveSpeed);
		movementDownRight = new Vector2 (downRightDirection.x * moveSpeed, downRightDirection.y * moveSpeed);
		// Check to see if the screen is being touched
		if (Input.touchCount > 0)
		{
			// Get the touch info
			Touch t = Input.GetTouch(0);
			
			// Did the touch action just begin?
			if (t.phase == TouchPhase.Began)
			{
				//moveSpeed = 5;
				// Are we touching the left arrow?
				if (guiLeft.HitTest(t.position, Camera.main))
				{
					Debug.Log("Touching Left Control");
					moveLeft = true;
					animLeft = true;
				}
				
				// Are we touching the right arrow?
				if (guiRight.HitTest(t.position, Camera.main))
				{
					Debug.Log("Touching Right Control");
					moveRight = true;
					animRight = true;
				}

				if (guiUp.HitTest(t.position, Camera.main))
				{
					Debug.Log("Touching Jump Control");
					moveUp = true;
					animUp = true;
				}

				if (guiDown.HitTest(t.position, Camera.main))
				{
					Debug.Log("Touching Down Control");
					moveDown = true;
					animDown = true;
				}

				if (guiUpRight.HitTest(t.position, Camera.main))
				{
					Debug.Log("Touching Up Right Control");
					moveUpRight = true;
					animRight = true;
				}

				if (guiUpLeft.HitTest(t.position, Camera.main))
				{
					Debug.Log("Touching Up Left Control");
					moveUpLeft = true;
					animLeft = true;
				}

				if (guiDownLeft.HitTest(t.position, Camera.main))
				{
					Debug.Log("Touching Down Left Control");
					moveDownLeft = true;
					animLeft = true;
				}

				if (guiDownRight.HitTest (t.position, Camera.main))
				{
					Debug.Log("Touching Down right Control");
					moveDownRight = true;
					animRight = true;
				}

				// Are we touching the jump button?
				if (guiJump.HitTest(t.position, Camera.main))
				{
					Debug.Log("Touching Jump Control");
					doJump = true;
				}

			}
			
			// Did the touch end?
			if (t.phase == TouchPhase.Ended)
			{
				// Stop all movement
				doJump = moveLeft = moveRight = moveUp = moveDown = moveUpLeft =
					moveUpRight = animRight = animLeft = moveDownRight = moveDownLeft =  false;
				rigidbody2D.velocity = Vector2.zero;
			}
		}
						// Is the left mouse button down?
						if (Input.GetMouseButtonDown (0)) {
								//moveSpeed = 5;
								// Are we clicking the left arrow?
								if (guiLeft.HitTest (Input.mousePosition, Camera.main)) {
										Debug.Log ("Touching Left Control");
										moveLeft = true;
										animLeft = true;
								}
			
								// Are we clicking the right arrow?
								if (guiRight.HitTest (Input.mousePosition, Camera.main)) {
										moveRight = true;
										animRight = true;
								}

								if (guiUp.HitTest (Input.mousePosition, Camera.main)) {
										Debug.Log ("Touching Up Control");
										moveUp = true;
										animUp = true;
								}

								if (guiDown.HitTest (Input.mousePosition, Camera.main)) {
										Debug.Log ("Touching Down Control");
										moveDown = true;
										animDown = true;
								}

								if (guiUpRight.HitTest (Input.mousePosition, Camera.main)) {
										Debug.Log ("Touching Up Right Control");
										moveUpRight = true;
										animRight = true;
								}

								if (guiUpLeft.HitTest (Input.mousePosition, Camera.main)) {
										Debug.Log ("Touching Up Left Control");
										moveUpLeft = true;
										animLeft = true;
								}

								if (guiDownLeft.HitTest (Input.mousePosition, Camera.main)) {
										Debug.Log ("Touching Down Left Control");
										moveDownLeft = true;
										animLeft = true;
								}

								if (guiDownRight.HitTest (Input.mousePosition, Camera.main)) {
										Debug.Log ("Touch Down Right Control");
										moveDownRight = true;
										animRight = true;
								}
			
								// Are we clicking the jump button?
								if (guiJump.HitTest (Input.mousePosition, Camera.main)) {
										Debug.Log ("Touching Jump Control");
										doJump = true;
								}
						}
		if (Input.GetMouseButtonUp(0))
		{
			// Stop all movement on left mouse button up
			doJump = moveLeft = moveRight = moveUp = moveDown = animLeft =
				moveDownLeft = moveUpRight = moveUpLeft = animRight = 
				moveDownRight = false;
			rigidbody2D.velocity = Vector2.zero;
		}

	}


	void FixedUpdate()
	{
		// Set velocity based on our movement flags.
		if (moveLeft)
		{
			rigidbody2D.velocity = -Vector2.right * moveSpeed;

			if(animLeft){

				nyanAnimator = renderer as SpriteRenderer;

				int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
				index = index % left.Length;
				nyanAnimator.sprite = left [index];

			}
		}
		
		if (moveRight)
		{
			rigidbody2D.velocity = Vector2.right * moveSpeed;

			if(animRight){

				nyanAnimator = renderer as SpriteRenderer;

				int index1 = (int)(Time.timeSinceLevelLoad * framesPerSecond);
				index1 = index1 % right.Length;
				nyanAnimator.sprite = right [index1];

			}
		}

		if (moveUp) 
		{
			rigidbody2D.velocity = Vector2.up * moveSpeed;

			if(animUp){
				
				nyanAnimator = renderer as SpriteRenderer;
				
				int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
				index = index % up.Length;
				nyanAnimator.sprite = up [index];
				
			}
		}

		if (moveDown) 
		{
			rigidbody2D.velocity = -Vector2.up * moveSpeed;

			if(animDown){
				
				nyanAnimator = renderer as SpriteRenderer;
				
				int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
				index = index % down.Length;
				nyanAnimator.sprite = down [index];
				
			}
		}

		if (moveUpRight) {
				
			rigidbody2D.velocity = Vector2.one * moveSpeed;

			if(animRight){
				
				nyanAnimator = renderer as SpriteRenderer;
				
				int index1 = (int)(Time.timeSinceLevelLoad * framesPerSecond);
				index1 = index1 % right.Length;
				nyanAnimator.sprite = right [index1];
				
			}

		}

		if (moveUpLeft) {

			rigidbody2D.velocity = movementUpLeft;

			if(animLeft){
				
				nyanAnimator = renderer as SpriteRenderer;
				
				int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
				index = index % left.Length;
				nyanAnimator.sprite = left [index];
				
			}
		}

		if (moveDownLeft) {
				
			rigidbody2D.velocity = -Vector2.one * moveSpeed;

			if(animLeft){
				
				nyanAnimator = renderer as SpriteRenderer;
				
				int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
				index = index % left.Length;
				nyanAnimator.sprite = left [index];
				
			}
		}

		if (moveDownRight) {
				
			rigidbody2D.velocity = movementDownRight;

			if(animRight){
				
				nyanAnimator = renderer as SpriteRenderer;
				
				int index1 = (int)(Time.timeSinceLevelLoad * framesPerSecond);
				index1 = index1 % right.Length;
				nyanAnimator.sprite = right [index1];
				
			}
		}

		if (doJump)
		{
			// If we have not reached the maximum jump velocity, keep applying force.
			if (rigidbody2D.velocity.y < maxJumpVelocity)
			{
				rigidbody2D.AddForce(Vector2.up * jumpForce);
			} else {
				// Otherwise stop jumping
				doJump = false;
			}
		}
	}
}