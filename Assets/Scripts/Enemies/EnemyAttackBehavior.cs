using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackBehavior : MonoBehaviour
{
    [SerializeField] private float attackRate;
    [SerializeField] private float timeUntilNextAttack;
    private EnemyGun[] guns;
    
    // Start is called before the first frame update
    void Start()
    {
        attackRate = GetComponent<EnemyInfos>().enemyData.attackRate;
        timeUntilNextAttack = attackRate;
        guns = GetComponentsInChildren<EnemyGun>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timeUntilNextAttack >= 0)
        {
            timeUntilNextAttack -= Time.deltaTime;
        }

        else
        {
            foreach(EnemyGun gun in guns)
            {
                gun.Shoot();
            }

            timeUntilNextAttack = attackRate;
        }
    }

    
}
