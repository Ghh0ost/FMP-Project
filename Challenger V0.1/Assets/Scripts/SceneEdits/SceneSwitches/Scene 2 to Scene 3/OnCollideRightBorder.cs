using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollideRightBorder : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("hit " + col.gameObject.tag);


        if (col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Scene 3");
        }
    }
}
