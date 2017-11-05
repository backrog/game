using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    public GameObject SomePrefab;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        GameObject newfefeb = Instantiate(SomePrefab);
        Vector3 ranbommove = new Vector3();

        ranbommove.x = Random.Range(-5.0f, 5.0f);
        ranbommove.y = Random.Range(0.0f, 4.5f);
	}
}
