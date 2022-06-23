using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public float speed = 3f;
    private GameObject Player;


    void Start()
    {
        Player = GameObject.Find("Player");
        if(Player != null)
        {
            Player = GameObject.Find("Player");
        }
        else
        {
            Debug.Log("Dead!");
        }
    }


    void Update()
    {
        if (Player != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);
        }
        else
        {
            Debug.Log("Dead!");
        }
    }
}
