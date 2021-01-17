using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController player_charater_c;
    private Animator player_animator;
    private float speed = 3f;
    private Vector3 move_direction = Vector3.zero;
    void Start()
    {
        player_charater_c = gameObject.GetComponent<CharacterController>();
        player_animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();

    }

    void PlayerMove()
    {
        //if (player_charater_c.isGrounded)
        //{
        //if (Input.GetButton("Jump"))
        //{
        //    move_direction.y = 1;
        //}
        //}
        move_direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        player_animator.SetFloat("vertical",Input.GetAxis("Vertical"));       
        player_charater_c.SimpleMove(move_direction *speed);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log(hit.gameObject.name);
    }
}
