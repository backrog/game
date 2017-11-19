using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot3 : MonoBehaviour
{
    public float SpeedY;
    public Vector3 direction;
    public int hp;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 newPosition = transform.position;

        newPosition += direction * SpeedY * Time.deltaTime;

        transform.position = newPosition;
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "player")
        {
            Destroy(gameObject);
        }
    }
}
