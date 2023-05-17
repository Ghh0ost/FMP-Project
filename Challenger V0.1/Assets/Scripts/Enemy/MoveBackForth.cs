using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackForth : MonoBehaviour
{
    public GameObject Enemy;
    public float speed;

    public void Update()
    {
        float x = Mathf.PingPong(Time.time * speed, 1) * 6 - 3;
        Enemy.transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}
