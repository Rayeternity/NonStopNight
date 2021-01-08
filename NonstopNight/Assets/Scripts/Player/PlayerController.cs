using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController player_charater_c;
    public float speed = 1.0f;
    private Vector3 move_direction = Vector3.zero;
    void Start()
    {
        player_charater_c = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.W))
        //{            
        //    PlayerMoveForward();
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    PlayerMoveForward();
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    PlayerMoveForward();
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    PlayerMoveForward();
        //}
        if (player_charater_c.isGrounded)
        {

            move_direction = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            move_direction *= speed;

            if (Input.GetButton("Jump"))
            {
                move_direction.y = 1;
            }


            // Move the controller
            player_charater_c.Move(move_direction * Time.deltaTime);
        }
    }

    void PlayerMoveForward()
    {
        gameObject.GetComponent<Animation>().Play("run1");
        gameObject.GetComponent<Transform>().Translate(0, 0, 0.01f);
    }
}
