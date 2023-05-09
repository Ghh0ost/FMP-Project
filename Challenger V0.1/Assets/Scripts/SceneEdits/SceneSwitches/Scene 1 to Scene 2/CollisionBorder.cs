using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionBorder : MonoBehaviour
{
    // called when the cube hits the floor
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("hit " + col.gameObject.tag);


        if (col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Scene 2");
        }
    }
}
