using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("hit " + col.gameObject.tag);


        if (col.gameObject.tag == "Active Border 2")
        {
            SceneManager.LoadScene("MeetTheKing");
        }
        if (col.gameObject.tag == "Active Border")
        {
            SceneManager.LoadScene("Scene 1");
        }
    }
}
