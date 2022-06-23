using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float aliveTime = 2f;
    public bool enabled;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);

    }

    void Update()
    {
        Destroy(gameObject, aliveTime);
    }
}
