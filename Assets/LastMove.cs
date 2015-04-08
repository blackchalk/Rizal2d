using UnityEngine;
using System.Collections;

public class LastMove : MonoBehaviour {

	public Sprite[] GCs;
	public float framesPerSecond = 5f;
	public SpriteRenderer nyanAnimator2;

	public int startAnims = 0;

	private Storage storage;

	// Use this for initialization
	void Start () {
	
	}

	void Awake(){
		storage = GameObject.Find ("Storage").GetComponent<Storage> ();
	}
	
	// Update is called once per frame
	void Update () {
		startAnims = storage.lastAnim;
	}

	void FixedUpdate(){
		if(startAnims == 1){//
			nyanAnimator2 = renderer as SpriteRenderer;
			nyanAnimator2.sprite = GCs [0];
		}

		if(startAnims == 2){
			nyanAnimator2 = renderer as SpriteRenderer;
			nyanAnimator2.sprite = GCs [1];
		}
	}
}
