using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }
}
