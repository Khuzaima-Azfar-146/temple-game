using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class shrink : MonoBehaviour
{
    bool shrunk;
    public Animator animator;
    [SerializeField] private NewBehaviourScript player;
    [SerializeField] private shoot slash;
    Vector3 originalScale;
    // Start is called before the first frame update
    void Start()
    {
        shrunk = false;
        originalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) && !shrunk)
        {
            transform.localScale = new Vector3(0.4f, 0.4f, 1);
            player.scale = new Vector3(0.4f, 0.4f, 1);
            shrunk = true;
            animator.SetBool("Shrunk", shrunk);
            slash.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.S) && shrunk)
        {
            transform.localScale = originalScale;
            player.scale = originalScale * new Vector2(-1,1);
            shrunk = false;
            animator.SetBool("Shrunk", shrunk);
            slash.enabled = true;
        }
    }
}
