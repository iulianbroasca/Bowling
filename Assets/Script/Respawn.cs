using UnityEngine;
using System.Collections;


public class Respawn : MonoBehaviour 
{
    public float sec = 0f;
    public int att = 0;
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    sec += Time.deltaTime;
        if (sec > 7 && att<2 )
        {
            att++;
            transform.position = new Vector3(0.5f, 0.4f, -9f);
            sec = 0f;
            
        }
            
	}
}
