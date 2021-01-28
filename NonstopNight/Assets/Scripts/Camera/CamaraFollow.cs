using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour
{
    private Transform player_pos;
    // Start is called before the first frame update
    void Start()
    {
        player_pos = GameObject.Find("SwordShieldRedKnight").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move_pos =  new Vector3(-1.57f, 11.18f, -6.67f);
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, move_pos + player_pos.position, Time.deltaTime*5);
    }
}
