using UnityEngine;
using System.Collections;

public class ControllPlayer : MonoBehaviour {
	public float speed = 1f;
	public float x = 1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) 
			transform.position -= new Vector3 (speed * Time.deltaTime, 0.0f, 0.0f);
				//transform.position -= new Vector3 (x, 0.0f, 0.0f);
		
		if (Input.GetKey (KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
			transform.position += new Vector3 (speed * Time.deltaTime, 0.0f, 0.0f);
				//transform.position += new Vector3 (x, 0.0f, 0.0f);
	}
}
