using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController player_charater_c;
    private Animator player_animator;
    private float speed = 4f;
    private Vector3 move_direction = Vector3.zero;
    void Start()
    {
        player_charater_c = gameObject.GetComponent<CharacterController>();
        player_animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //¼ì²â½ÇÉ«ÒÆ¶¯
        PlayerMove();
        //¼ì²â½ÇÉ«¹¥»÷
        PlayerAttack01();
        //¼ì²â½ÇÉ«·­¹ö
        PlayerRoll();
    }

    void PlayerMove()
    {
        move_direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //²¥·ÅÒÆ¶¯¶¯»­
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            player_animator.SetBool("move", true);
        }
        else
        {
            player_animator.SetBool("move", false);
        }    
        player_charater_c.transform.forward = Vector3.Lerp(transform.forward, move_direction, 0.51f);
        player_charater_c.SimpleMove(move_direction * speed);
    }

    void PlayerRoll()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player_animator.SetTrigger("roll");
        }
    }

    void PlayerAttack01()
    {
        if (Input.GetMouseButtonDown(0))
        {
            player_animator.SetBool("attack1",true);
        }
        else if(Input.GetMouseButtonUp(0))
        {
            player_animator.SetBool("attack1", false);
        }
    }



    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //Debug.Log(hit.gameObject.name);
    }
}
