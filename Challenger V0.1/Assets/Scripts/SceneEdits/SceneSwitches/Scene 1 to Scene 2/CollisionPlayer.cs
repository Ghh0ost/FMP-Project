using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionPlayer : MonoBehaviour
{
    void OnCollisionEnter(Collider other)
    {
        if (other.gameObject.tag == "Active Border")
            SceneManager.LoadScene("Scene 2");
    }
}
