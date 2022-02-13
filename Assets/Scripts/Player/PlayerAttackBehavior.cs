using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackBehavior : MonoBehaviour
{
    private Gun[] guns;
    private bool canShoot;

    // Start is called before the first frame update
    void Start()
    {
        guns = GetComponentsInChildren<Gun>();
    }

    // Update is called once per frame
    void Update()
    {
        canShoot = Input.GetKeyDown(KeyCode.Space);
        if (canShoot)
        {
            canShoot = false;
            foreach (Gun gun in guns)
            {
                gun.Shoot();
            }
        }
    }
}

