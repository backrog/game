using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotspeed : MonoBehaviour
{
    public float SpeedY;
    public float delay;
	
	void Start ()
    {
		
	}
	
	
	void Update ()
    {
        Vector3 newposition = transform.position;

        newposition.y -= SpeedY * Time.deltaTime;

        transform.position = newposition;
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "player")
        {
            Destroy(gameObject);
            collider.gameObject.GetComponent<bang>().additem();
        }
    }
}
