using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubblesDestroy : MonoBehaviour
{
    private double timeDelay;

    private void Start()
    {
        timeDelay = 0f;
    }

    private void Update()
    {
        if (timeDelay < 0.75)
        {
            timeDelay += (Time.deltaTime);

        }

        else
        {
            Destroy(gameObject);
        }
    }
}

