using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.tag.Equals("Bullet"))
        {
            Destroy(coll.gameObject);
            Destroy(gameObject);
        }
        else if (coll.gameObject.tag.Equals("Player"))
        {
            Destroy(coll.gameObject);
            Destroy(gameObject);
        }
    }
}
