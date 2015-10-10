using UnityEngine;
using System.Collections;

public class TrapScript : MonoBehaviour {
	//shoots a 'fireball' every x seconds

	public GameObject fireballPrefab;
	float interval = 3f; //3second

	string shootDir;
	// Use this for initialization
	void Start () {
	
	}
	void shoot(){
		GameObject fire = (GameObject)Instantiate (fireballPrefab, this.gameObject.transform.position, this.gameObject.transform.rotation);
		// clone.rigidbody.AddForce(clone.transform.forward * shootForce);
		
		fire.transform.rotation = this.GetComponentInChildren<Transform> ().transform.rotation;
		fire.GetComponent<Rigidbody> ().AddForce (fire.transform.up* 500f); //Ice balls are slower

	}

	public void GetDirection(string Dir){
		shootDir = Dir;

	}
	// Update is called once per frame
	void Update () {
	
	}
}


