using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxHp;

    private float currentHp;

    // Use this for initialization
	void Start ()
    {
        currentHp = maxHp;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void takeDamage(float damage)
    {
        currentHp -= damage;
    }
}
