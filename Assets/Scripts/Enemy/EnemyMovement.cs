using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private GameObject playerTracker;
    [SerializeField] public float speed;

    // Start is called before the first frame update
    void Start()
    {
        playerTracker = GameObject.FindGameObjectWithTag("PlayerTracker");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerTracker.transform.position, speed * Time.fixedDeltaTime);
    }
}
