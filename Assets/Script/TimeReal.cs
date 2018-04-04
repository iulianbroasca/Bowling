using UnityEngine;
using System.Collections;

public class TimeReal : MonoBehaviour
{
    public float sec = 0f;

    void start ()
    {

    }
	// Update is called once per frame
	void Update () 
    {
        sec += Time.deltaTime;
        if (sec > 25)
            Application.LoadLevel("MainMenu");
	}
}
