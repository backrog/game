using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deobject : MonoBehaviour
{
    public GameObject SomePefab;
    public float delay;
    float time;
	
	void Update ()
    {
        if (time >= delay)
        {
            time = 0;
            GameObject newfrefeb = Instantiate(SomePefab);
            Vector3 randomPos = new Vector3();

            randomPos.x = Random.Range(-5.0f, 5.0f);
            randomPos.y = 6.0f;
            randomPos.z = 0.0f;
            newfrefeb.transform.position = randomPos;
        }
        time += Time.deltaTime;
    }
}
