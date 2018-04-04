using UnityEngine;
using System.Collections;

public class Controll : MonoBehaviour 
{
	public float speed = 1f;
	public float x = 1f;
    public float LaucherForceBall = 1000f;
    public bool ouut = true;
    public float sec = 0f;
    public int att = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {    
        sec += Time.deltaTime;
        if (sec > 7 && att < 2)
        {
            att++;
            transform.position = new Vector3(0.5f, 0.4f, -9f);
            sec = 0f;
            ouut = true;
        }



		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) 
			transform.position -= new Vector3 (speed * Time.deltaTime, 0.0f, 0.0f);
				//transform.position -= new Vector3 (x, 0.0f, 0.0f);
		
		if (Input.GetKey (KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
			transform.position += new Vector3 (speed * Time.deltaTime, 0.0f, 0.0f);
				//transform.position += new Vector3 (x, 0.0f, 0.0f);
        if (Input.GetKey(KeyCode.Space) & ouut == true || Input.GetKey(KeyCode.W) & ouut == true || Input.GetKey(KeyCode.UpArrow) & ouut == true)
        {
            GetComponent<Rigidbody>().AddForce(LaucherForceBall * transform.forward);
            ouut = false;
            
        }
	}
    void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(LaucherForceBall * transform.forward);
    }
}
