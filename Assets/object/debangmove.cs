using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debangmove : MonoBehaviour
{
    public float SpeedY;
    Vector3 direction;

    // Use this for initialization
    void Start ()
    {
		GameObject player = GameObject.FindGameObjectWithTag("player");
        if (player == null)
            return;

        direction = player.transform.position - transform.position;
        direction.Normalize();
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
            Destroy(collider.gameObject);
        }
    }
}
