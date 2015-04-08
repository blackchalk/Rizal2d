using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	private Storage storage;

	public int move = 0;
	public bool startMove = false;

	public float moveSpeed = 2f;

	public Sprite[] moves;
	public float framesPerSecond = 5f;
	public SpriteRenderer nyanAnimator1;

	//public bool animNow = false;
	// Use this for initialization
	void Start () {
	
	}

	void Awake() {
		storage = GameObject.Find ("Storage").GetComponent<Storage> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(move == 1){
			startMove = true;
		}
	}

	void FixedUpdate() {
		if(startMove){
			rigidbody2D.velocity = -Vector2.right * moveSpeed;

			nyanAnimator1 = renderer as SpriteRenderer;
			
			int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
			index = index % moves.Length;
			nyanAnimator1.sprite = moves [index];
		}
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Object2") {
			rigidbody2D.velocity = Vector2.zero;
			moveSpeed = 0f;
			move = 0;
			startMove = false;
			nyanAnimator1.sprite = moves [1];
			storage.cont = 1;
		}
	}
}
