using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bang : MonoBehaviour
{
    public GameObject Someprfeb;
    public float delay;
    float time;

	
	void Update ()
    {
        if (Input.GetKey(KeyCode.Space)&&time>=delay)
        {
            time = 0;
            GameObject newfrefeb = Instantiate(Someprfeb);
            newfrefeb.transform.position = transform.position;
        }
        time += Time.deltaTime;
    }
}
