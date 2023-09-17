using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSound : MonoBehaviour
{
    [SerializeField]
    private float remainTime;

    void Update()
    {
        remainTime -= Time.deltaTime;

        if (remainTime <= 0)
        {
            Destroy(gameObject);
        }
    }
}