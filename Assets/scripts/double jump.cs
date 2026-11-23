using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doublejump : MonoBehaviour
{

    bool can_doublejump;
    public NewBehaviourScript Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && (can_doublejump || Player.isgrounded))
        {
            if (Player.isgrounded)
            {
                can_doublejump = true;
            }
            else
            {
                can_doublejump = false;
            }
            Player.player.velocity = new Vector2(Player.player.velocity.x, Player.jumpforce);
        }
    }
}
