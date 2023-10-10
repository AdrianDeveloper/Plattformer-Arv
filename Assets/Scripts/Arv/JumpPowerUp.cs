using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPowerUp : PowerUpItem
{
    //PlayerMovement PlayerMovement;
    

    public override void PowerUp()
    {
        player.GetComponent<PlayerMovement>().jumpForce = 600;
    }
}
