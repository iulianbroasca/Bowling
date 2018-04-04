using UnityEngine;
using System.Collections;

public class PinBowling : MonoBehaviour
{
    public float x = 1;
    public float y = 1;
    public float z = 1;

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector3(x, y, z));
    }
}
