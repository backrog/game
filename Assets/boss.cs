using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    public GameObject SomePrefeb;
    Vector3 direction;
    public float SpeedY;
    Vector3 randomPos = new Vector3();
    public float delay;
    float wait;
    public float debangdelay;
    public float shootAngle;
    float time;
    public int maxhp;
    int hp;
    public GameObject hpprefab;
    public float hpx;
    public float hpy;
    GameObject hpui;
    void Start ()
    {
        randomPos.x = Random.Range(-8.0f, 8.0f);
        randomPos.y = Random.Range(0.0f, 4.5f);
        randomPos.z = 0.0f;

        direction = randomPos - transform.position;
        direction.Normalize();
        hp = maxhp;
        hpui = Instantiate(hpprefab);

        GameObject canvas = GameObject.Find("Canvas");
        hpui.transform.SetParent(canvas.transform);
        hpui.transform.localPosition = new Vector3(hpx, hpy);
    }
	
	void Update ()
    {
        if (Vector2.Distance(transform.position,randomPos)<0.8f)
        {
            wait += Time.deltaTime;
            if (wait >= delay)
            {
                randomPos.x = Random.Range(-8.0f, 8.0f);
                randomPos.y = Random.Range(0.0f, 4.5f);
                randomPos.z = 0.0f;

                direction = randomPos - transform.position;
                direction.Normalize();
                wait = 0.0f;
            }
            if (time >= debangdelay)
            {
                GameObject player = GameObject.FindGameObjectWithTag("player");
                if (player == null)
                    return;

                Vector3 shootdir = player.transform.position - transform.position;
                shootdir.Normalize();
                Vector2 ccw = Quaternion.AngleAxis(-shootAngle, Vector3.forward) * shootdir;
                Vector2 cw = Quaternion.AngleAxis(shootAngle, Vector3.forward) * shootdir;

                time = 0;
                GameObject newfrefeb = Instantiate(SomePrefeb);
                newfrefeb.transform.position = transform.position;
                GameObject newfrefeb2 = Instantiate(SomePrefeb);
                newfrefeb2.transform.position = transform.position;
                GameObject newfrefeb3 = Instantiate(SomePrefeb);
                newfrefeb3.transform.position = transform.position;
                newfrefeb.GetComponent<shot3>().direction = shootdir;
                newfrefeb2.GetComponent<shot3>().direction = cw;
                newfrefeb3.GetComponent<shot3>().direction = ccw;

            }
            time += Time.deltaTime;
        }
        else
        {
            Vector3 newPosition = transform.position;

            newPosition += direction * SpeedY * Time.deltaTime;

            transform.position = newPosition;
        }
    }
    public void damage()
    {
        hp--;
        hpui.transform.localScale = new Vector3(1.0f, (float)hp / maxhp);
        if (hp <= 0)
        {
            Destroy(hpui);
            Destroy(gameObject);
        }
    }
}
