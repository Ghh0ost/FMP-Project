using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderController : MonoBehaviour
{
    public Transform player;
    public float padding = 0.5f;

    private float xMin, xMax, yMin, yMax;

    private void Start()
    {
        CalculateBorders();
    }

    private void CalculateBorders()
    {
        Camera camera = Camera.main;

        xMin = camera.ViewportToWorldPoint(new Vector2(0, 0)).x + padding;
        xMax = camera.ViewportToWorldPoint(new Vector2(1, 0)).x - padding;
        yMin = camera.ViewportToWorldPoint(new Vector2(0, 0)).y + padding;
        yMax = camera.ViewportToWorldPoint(new Vector2(0, 1)).y - padding;
    }

    private void Update()
    {
        float clampedX = Mathf.Clamp(player.position.x, xMin, xMax);
        float clampedY = Mathf.Clamp(player.position.y, yMin, yMax);
        player.position = new Vector3(clampedX, clampedY, player.position.z);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(new Vector2(xMin, yMin), new Vector2(xMax, yMin));
        Gizmos.DrawLine(new Vector2(xMin, yMax), new Vector2(xMax, yMax));
        Gizmos.DrawLine(new Vector2(xMin, yMin), new Vector2(xMin, yMax));
        Gizmos.DrawLine(new Vector2(xMax, yMin), new Vector2(xMax, yMax));
    }
}

