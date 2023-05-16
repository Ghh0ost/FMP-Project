using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerChange : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Active Border 2"))
        {
            SceneManager.LoadScene(1);
        }
        else if (other.CompareTag("Active Border"))
        {
            SceneManager.LoadScene(3);
        }
    }
}
