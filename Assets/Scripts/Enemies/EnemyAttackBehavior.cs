using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackBehavior : MonoBehaviour
{
    [SerializeField] private float attackRate;
    [SerializeField] private float timeUntilNextAttack;
    private float delay = 0.5f;
    [SerializeField] private float delayCounter = 0;
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
        if(timeUntilNextAttack >= 0 && Vector2.Distance(transform.position, GetComponent<EnemyMovement>().playerTracker.transform.position) > 0.05f)
        {
            timeUntilNextAttack -= Time.deltaTime;
        }

        else if(timeUntilNextAttack < 0)
        {
            foreach(EnemyGun gun in guns)
            {
                gun.Shoot();
            }

            timeUntilNextAttack = attackRate;
        }

        else if(Vector2.Distance(transform.position, GetComponent<EnemyMovement>().playerTracker.transform.position) <= 0.05f)
        {

            delayCounter += Time.deltaTime;
            if(delayCounter >= delay)
            {
                foreach (EnemyGun gun in guns)
                {
                    gun.Shoot();
                }

                delayCounter = 0;
            }
           
        }
    }

    
}
