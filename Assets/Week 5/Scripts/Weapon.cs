using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float speed = 3f;
    Rigidbody2D rb;
    float counter;
    public float maxCount = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }

    private void FixedUpdate()
    {
        if(counter == maxCount)
        {
            Destroy(gameObject);
            counter = 0;
        }
        else if(counter < maxCount)
        {
            counter ++;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SendMessage("TakeDamage", 1);
    }
}
