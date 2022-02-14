using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject playerTracker;
    [SerializeField] public float speed;


    // Start is called before the first frame update
    void Start()
    {
        playerTracker = GameObject.FindGameObjectWithTag("PlayerTracker");
        speed = GetComponent<EnemyInfos>().enemyData.speed;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerTracker.transform.position, speed * Time.fixedDeltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("PlayerBullet"))
        {

            GetDamage(2f);
            Destroy(collision.gameObject);
        }
    }

    void GetDamage(float damage)
    {
        Health health = GetComponent<Health>();
        health.GetDamage(damage);
        
    }
}
