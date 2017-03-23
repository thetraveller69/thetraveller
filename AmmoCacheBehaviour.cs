using UnityEngine;
using System.Collections;

public class AmmoCacheBehaviour : MonoBehaviour
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

    void OnTriggerEnter (Collider collision)
    {
       if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            if (MyData.bullets <= 18)
            {
                MyData.bullets += 12;
                GameObject.Find("Init").GetComponent<MyData>().UpdateBullets();
            }

        }
    }
       

}

