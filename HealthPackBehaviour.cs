using UnityEngine;
using System.Collections;

public class HealthPackBehaviour : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 100f * Time.deltaTime, 0f));
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject); // Destroys Health Pack
            if (MyData.pHealth <= 90)
            {
                MyData.pHealth += 10;
                GameObject.Find("Init").GetComponent<MyData>().UpdateHealth();
            }
        }
        else if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            if (MyData.pHealth <= 50)
            {
                MyData.pHealth += 50;
                GameObject.Find("Init").GetComponent<MyData>().UpdateHealth();
            }
        }
        else
        {
            Destroy(gameObject);
            if (MyData.pHealth <= 80)
            {
                MyData.pHealth += 20;
                GameObject.Find("Init").GetComponent<MyData>().UpdateHealth();
            }
        } 
        
       // else
        {
            Destroy(gameObject);
            if (MyData.pHealth <= 70)
            {
                MyData.pHealth += 30;
                GameObject.Find("Init").GetComponent<MyData>().UpdateHealth();
            }
        } 

       // else
        {
            Destroy(gameObject);
            if (MyData.pHealth <= 60)
            {
                MyData.pHealth += 40;
                GameObject.Find("Init").GetComponent<MyData>().UpdateHealth();
            }
        }
    }
}
