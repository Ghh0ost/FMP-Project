using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("enter"))
        {
            SceneManager.LoadScene("Scene 1");
        }
    }
}
