using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour
{
    public float xmij = 0.5f;
    public float xmin = -2f;
    public float xmax = 3f;
    public float x1 = 5f;
    public float y = 0.5f;
    public float z = -9f;
    public Vector3 position;
    //public bool left = false;
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector3(xmij * Time.deltaTime, y, z);
            //if (xmij <= xmax || xmij>=xmin)
            //{
            //    if (xmij == xmin)
            //    {
            //        transform.position = new Vector3(xmij * Time.deltaTime, y, z);
            //    }
            //}
        //if (left == false)
        //{
        //    transform.Rotate(0, -15, 0);
        //    left = true;
        //}
        //if (left = true)
        //{
        //    transform.Rotate(0, 15, 0);
        //    left = false;
        //}

         //transform.position = new Vector3(x1 * Time.deltaTime, y, z);
        //transform.position = new Vector3(x2 * Time.deltaTime, y, z);
	}

}
