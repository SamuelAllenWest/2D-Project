using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDestroy : MonoBehaviour
{
    private double timeDelay;

    private void Start()
    {
        timeDelay = 0f;
    }

    private void Update()
    {
        if (timeDelay < 1)
        {
            timeDelay += (Time.deltaTime);

        }

        else
        {
            Destroy(gameObject);
        }
    }









}
