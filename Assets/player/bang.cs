using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bang : MonoBehaviour
{
    public GameObject Someprfeb;
    public float delay;
    public float itemdelay;
    float time;
    int item;
    public Text itemtext;
    public float itemlength;
    List<float> length = new List<float>();
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.Space)&&time>=delay)
        {
            time = 0;
            GameObject newfrefeb = Instantiate(Someprfeb);
            newfrefeb.transform.position = transform.position;
        }
        time += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (item > 0)
            {
                item--;
                delay -= itemdelay;
                length.Add(itemlength);
            }
        }
        itemtext.text = "x" + item;
        for (int i = 0; i < length.Count; i++ )
        {
            length[i] -= Time.deltaTime;
            if(length[i]<0)
            {
                length.RemoveAt(i);
                i--;
                delay += itemdelay;
            }
        }
    }
    public void additem()
    {
        item++;
    }
}
