using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform targetTransform;
    public Transform[] borders;
    public Transform[] playerBorders;

    public float xOffset;
    public float yOffset;

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
        if (playerBorders[3].position.y < borders[3].position.y)
        {
            return borders[3].position.y + 5;
        }
        if (playerBorders[1].position.y > borders[1].position.y)
        {
            return borders[1].position.y - 5;
        }

        return targetTransform.position.y + yOffset;
    }

    private float checkWidth()
    {
        if (Mathf.Min(playerBorders[0].position.x, playerBorders[2].position.x) + xOffset < borders[0].position.x)
        {
            return borders[0].position.x + 9;
        }

        if (Mathf.Max(playerBorders[0].position.x, playerBorders[2].position.x) + xOffset > borders[2].position.x)
        {
            return borders[2].position.x - 9;
        }

        return targetTransform.position.x + xOffset;
    }
    
}
