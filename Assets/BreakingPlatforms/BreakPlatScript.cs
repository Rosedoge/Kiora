using UnityEngine;
using System.Collections;

public class BreakPlatScript : MonoBehaviour {
	public int[] BreakValues;
	public Sprite[] sprites;
	float timer;
	int[] BreakValuesConst;
	// Use this for initialization
	void Start () {
		for (int x = 0; x < 4; x++) {
			BreakValuesConst[x] = BreakValues[x];
		}

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
