using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slash : MonoBehaviour
{
    public float slashspeed;
    public Rigidbody2D theRB;

    public Vector2 movedirection;
    // Start is called before the first frame update
    void Start()
    {
        if (movedirection.x > 0)
        {
            transform.localScale = -transform.localScale;
        }

    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = movedirection * slashspeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("breakable"))
        {
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);
    }
}
