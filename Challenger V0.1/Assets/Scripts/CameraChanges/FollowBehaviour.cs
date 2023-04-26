using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField]
    protected Transform trackingTarget;

    // ...

    void Update()
    {
        transform.position = new Vector3(trackingTarget.position.x,
             trackingTarget.position.y, transform.position.z);
    }
}
