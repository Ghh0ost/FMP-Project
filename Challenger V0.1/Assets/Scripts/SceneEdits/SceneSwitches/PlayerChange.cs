using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChange : MonoBehaviour
{
    public player GameObject;
    public void LoadNextScene()
    {
        if (player.transform.position.x == 7.291129)
        {
            SceneManager.LoadScene("Scene 3");
        }

        if (player.transform.position.x == -9.491129)
        {
            SceneManager.LoadScene("Scene 1");
        }

    }
}
