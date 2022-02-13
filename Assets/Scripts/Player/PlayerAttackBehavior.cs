using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackBehavior : MonoBehaviour
{
    private PlayerGun[] guns;
    private bool canShoot;

    // Start is called before the first frame update
    void Start()
    {
        guns = GetComponentsInChildren<PlayerGun>();
    }

    // Update is called once per frame
    void Update()
    {
        canShoot = Input.GetKeyDown(KeyCode.Space);
        if (canShoot)
        {
            canShoot = false;
            foreach (PlayerGun gun in guns)
            {
                gun.Shoot();
            }
        }
    }
}

