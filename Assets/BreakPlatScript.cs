using UnityEngine;
using System.Collections;

public class BreakPlatScript : MonoBehaviour {

	public Sprite[] sprites;
	float timer;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D col){
		timer += 0.1f;
		Debug.Log (timer + " is Timer");
		switch ((int)timer) {
		case 10:
			this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[1];
			break;
		case 20:
			this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[2];
			break;
		case 30:
			this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[3];
			break;
		case 40:
			Destroy(this.gameObject);
			break;
		}

	}
}
