using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform targetTransform;
    public Transform[] borders;

    // Update is called once per frame
	void Update ()
    {
        //*
        float xPos = checkWidth();
        float yPos = checkHeigth();
        
        transform.position = new Vector3(xPos, yPos, -10);
        /**/
    }

    private float checkHeigth()
    {
        if (transform.position.y < borders[3].position.y)
        {
            return borders[2].position.y;
        }
        if (transform.position.y > borders[1].position.y)
        {
            return borders[1].position.y;
        }

        return targetTransform.position.y;
    }

    private float checkWidth()
    {
        if (transform.position.x < borders[0].position.x - 1)
        {
            return borders[0].position.x;
        }

        if (transform.position.x > borders[2].position.x + 1)
        {
            return borders[2].position.x;
        }

        return targetTransform.position.x;
    }
    
}
