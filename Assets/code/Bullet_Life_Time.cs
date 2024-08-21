using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Life_Time : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 2f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Meteor")
        {
            Destroy(collision.collider.gameObject);
        }

        Destroy(gameObject);
    }
}
