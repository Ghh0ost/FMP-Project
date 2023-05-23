using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Playables;

public class DestroyOn3Clicks : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public float enemyHP = 10.0f;
    //textDisplay.text(enemyHP.ToString());
    public GameObject enemy;
    private float NewenemyHp;


    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            NewenemyHp = enemyHP - 2.5f;
            //textDisplay.text(NewenemyHp.ToString());
        }

        if (enemyHP >= 0)
        {
            Destroy(enemy);
        }
    }
}

