using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private Vector2 direction = Vector2.right;
    [SerializeField]
    private float remainTime = 3;

    private Rigidbody2D rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        remainTime -= Time.deltaTime;
        rigid.velocity = direction;

        if (remainTime <= 0)
        {
            Destroy(gameObject);
        }
    }
}