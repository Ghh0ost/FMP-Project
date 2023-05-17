using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DestroyOn3Clicks : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public float enemyHP = 10.0f;
    textDisplay.text(enemyHP.ToString());


    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            NewenemyHp = enemyHP - 2.5;
            textDisplay.text(NewenemyHp.ToString());
        }

        if (enemyHP >= 0)
        {
            Destroy(gameObject);
        }
    }
}

