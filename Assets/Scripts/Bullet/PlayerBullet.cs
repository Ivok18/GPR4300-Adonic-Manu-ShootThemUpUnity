using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb;
    private Vector2 trajectory;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        trajectory = new Vector2(0, 1);  
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = trajectory * speed * Time.fixedDeltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.CompareTag("Bound") || collision.transform.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }


}
