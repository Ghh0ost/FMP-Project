using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyable : MonoBehaviour
{
    
    public bool Destroy = false;

    private void OnMouseDown()
    {
        if (Destroy == true)
        {
            Destroy(gameObject);
        }
        if (Destroy == false)
        {

        }
        
    }
}

