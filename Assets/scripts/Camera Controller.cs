using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public BoxCollider2D boundsbox;

    private float halfwidth, halfheight;

    private void Start()
    {
        halfheight = Camera.main.orthographicSize;
        halfwidth = halfheight * Camera.main.aspect;
    }

    private void Update()
    {
        if (player != null)
        {
            transform.position = new Vector3(
                Mathf.Clamp(player.transform.position.x, boundsbox.bounds.min.x + halfwidth, boundsbox.bounds.max.x - halfwidth),
                Mathf.Clamp(player.transform.position.y, boundsbox.bounds.min.y + halfheight, boundsbox.bounds.max.y - halfheight),
                transform.position.z);
        }

    }
}
