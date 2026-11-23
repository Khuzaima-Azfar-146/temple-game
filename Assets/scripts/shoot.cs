using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{

    public slash slashController;
    public Transform slashpoint;
    public Animator anim;
    float timer;
    float time_of_slash = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = Time.time;
        if (Input.GetButtonDown("Fire1") && timer - time_of_slash > 0.40f)
        {
            Instantiate(slashController, slashpoint.position, slashpoint.rotation).movedirection = new Vector2(-transform.localScale.x, 0f);
            anim.SetTrigger("slashed");
            time_of_slash = timer;
        }
        else if (timer - time_of_slash > 0.20f)
        {
            anim.SetBool("slashed", false);
        }
    }
}
