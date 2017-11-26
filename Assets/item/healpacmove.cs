using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healpacmove : MonoBehaviour
{
    public float SpeedY;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
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
            collider.gameObject.GetComponent<player>().addhp();
        }
    }
}
