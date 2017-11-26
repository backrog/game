using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player : MonoBehaviour
{
    public GameObject lifeprefab;
    List<GameObject> life = new List<GameObject>();
    public int hp;
    public GameObject gameoverui;
    public float hpx;
    public float hpy;
    public float hpsize;

    void Start()
    {
        for(int i = 0; i < hp; i ++)
        {
            addhp();
        }
    }

    public void addhp()
    {
        if (life.Count >= hp)
        {
            return;
        }

        GameObject newhp = Instantiate(lifeprefab);
        GameObject canvas = GameObject.Find("Canvas");
        newhp.transform.SetParent(canvas.transform);
        newhp.transform.localPosition = new Vector3(hpx + hpsize * life.Count, hpy);
        life.Add(newhp);

    }

    public void damage()
    {
        if (life.Count == 0)
        {
            return;
        }
        Destroy(life[life.Count - 1]);
        life.RemoveAt(life.Count - 1);

        if (life.Count == 0)
        {
            Destroy(gameObject);
            gameoverui.SetActive(true);
        }
    }
}
