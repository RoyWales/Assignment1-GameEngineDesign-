using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 playerVelocity;
    private float playerSpeed = 4.0f;
    private float gravityValue = -3.0f;

    // Update is called once per frame
    void Update()
    {
        
        //This is for moving the character
        Vector3 move = new Vector3(Input.GetAxis("Horizontal")* -1, 0, Input.GetAxis("Vertical")* -1); //had to flip it (* -1)
        controller.Move(move * Time.deltaTime * playerSpeed);
        // This turns the player to face the direction they are moving in
        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }

}