using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemake : MonoBehaviour
{
    public float SpeedX;
    public float SpeedY;
    public GameObject gameoverui;

	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 newPosition = transform.position;

            newPosition.y += SpeedY * Time.deltaTime;

            transform.position = newPosition;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 newPosition = transform.position;

            newPosition.y -= SpeedY * Time.deltaTime;

            transform.position = newPosition;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 newPosition = transform.position;

            newPosition.x -= SpeedX * Time.deltaTime;

            transform.position = newPosition;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 newPosition = transform.position;

            newPosition.x += SpeedX * Time.deltaTime;

            transform.position = newPosition;
        }
        float x = transform.position.x;
        float y = transform.position.y;
        x = Mathf.Clamp(x, -8.2f, 8.2f);
        y = Mathf.Clamp(y, -5.0f, 5.0f);
        transform.position = new Vector3(x, y);
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "enemy" || collider.tag == "enemybullet")
        {
            Destroy(gameObject);
            Destroy(collider.gameObject);
            gameoverui.SetActive(true);
        }
    }
}
