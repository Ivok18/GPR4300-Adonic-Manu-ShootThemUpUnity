using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    public Bullet bullet;
    private EnemyData enemyData;

    private void Start()
    {
        enemyData = transform.parent.GetComponent<EnemyInfos>().enemyData;
    }

    
    public void Shoot()
    {
        // shoot
        GameObject bulletGo = Instantiate(bullet.gameObject, transform.position, Quaternion.identity); 

        //configure bullet
        Bullet _bullet = bulletGo.GetComponent<Bullet>(); 
        SpriteRenderer bulletSprite = bulletGo.transform.Find("Sprite").GetComponent<SpriteRenderer>();
        _bullet.trajectory = new Vector2(0, -1);
        _bullet.speed = enemyData.bulletsSpeed;
        bulletSprite.color = enemyData.color;        
    }

   
}
