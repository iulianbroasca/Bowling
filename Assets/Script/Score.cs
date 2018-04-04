using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour 
{
    public static int score;

    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
        score = 0;
    }
	
    void update ()
    {
        text.text = "Score: " + score;
    }
    //void OnGUI()
    //{
    //    GUI.contentColor = Color.yellow;
    //    GUI.Button(new Rect(10, 10, 70, 30), "Score =");
    //}

    //public void StartS()
    //{
    //    GetComponent<Rigidbody>().isKinematic = true;
    //    Score.score += 1;
    //}
}
