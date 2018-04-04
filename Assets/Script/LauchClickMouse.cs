using UnityEngine;
using System.Collections;

public class LauchClickMouse : MonoBehaviour 
{
    public float LaucherForceBall = 1000;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnMouseDown ()
    {
        GetComponent<Rigidbody>().AddForce(LaucherForceBall*transform.forward);
    }
}
