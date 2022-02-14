using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Transform healthbar;
    public float currentHealth;
    private float maxHealth = 100;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
 
    public void GetDamage(float damage)
    {
        currentHealth -= damage;
        healthbar.localScale = new Vector3(1, currentHealth / maxHealth, 1);
        if(transform.CompareTag("Player"))
        {
            if (currentHealth <= 0)
            {
                //Game Over
                SceneManager.LoadScene("Game Over");
            }
        }
        else
        {
            if (currentHealth <= 0)
            {
                GameObject enemiesHandlerGo = GameObject.Find("EnemiesHandler").GetComponent<EnemiesHandler>().buttonForNextEnemy.gameObject;
                enemiesHandlerGo.SetActive(true);
                Destroy(gameObject);
            }
        }
       
    }
}
