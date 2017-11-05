using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debang : MonoBehaviour
{
    public GameObject Someprfeb;
    public float delay;
    float time;

	void Start ()
    {
	 
	}
	
	void Update ()
    {
        if (time >= delay)
        {
            time = 0;
            GameObject newfrefeb = Instantiate(Someprfeb);
            newfrefeb.transform.position = transform.position;
        }
        time += Time.deltaTime;
	}
}
