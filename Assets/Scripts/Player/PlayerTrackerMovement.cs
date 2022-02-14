using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrackerMovement : MonoBehaviour
{
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector2(player.transform.position.x, transform.position.y);
    }
}
