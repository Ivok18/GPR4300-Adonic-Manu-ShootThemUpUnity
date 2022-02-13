using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public PlayerBullet bullet;

    public void Shoot()
    {
        GameObject bulletGo = Instantiate(bullet.gameObject, transform.position, Quaternion.identity);
    }
}
