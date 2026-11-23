using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D player;
    public float moveespeed;
    public float jumpforce;

    public Transform groundcheck;
    public bool isgrounded;
    public LayerMask groundlayer;
    public Vector3 scale;

    public Animator anim;

    void Start()
    {
        scale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {

        if (player.velocity.x < 0)
        {
            transform.localScale = scale;
        }
        else if (player.velocity.x > 0)
        {
            transform.localScale = new Vector3(-scale.x, scale.y, scale.z);
        }

        player.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveespeed, player.velocity.y);

        isgrounded = Physics2D.OverlapCircle(groundcheck.position, 0.2f, groundlayer);

        if (Input.GetButtonDown("Jump") && isgrounded)
        {
            player.velocity = new Vector2(player.velocity.x, jumpforce);
        }

        anim.SetBool("isGrounded", isgrounded);
        anim.SetFloat("speed", Mathf.Abs(player.velocity.x));

    }
}
