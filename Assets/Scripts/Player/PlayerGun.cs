using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    public Bullet bullet;
    public void Shoot()
    {
        GameObject bulletGo = Instantiate(bullet.gameObject, transform.position, Quaternion.identity);
        bulletGo.GetComponent<Bullet>().trajectory = new Vector2(0, 1);
    }
}
