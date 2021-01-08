using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Animation>().Play("idle");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {            
            PlayerMoveForward();
        }
    }

    void PlayerMoveForward()
    {
        gameObject.GetComponent<Animation>().Play("run1");
        gameObject.GetComponent<Transform>().Translate(0, 0, 0.01f);
    }
}
