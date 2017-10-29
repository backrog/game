using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demove : MonoBehaviour
{
    public float SpeedY;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 newPosition = transform.position;

        newPosition.y -= SpeedY * Time.deltaTime;

        transform.position = newPosition;
    }
    
}
