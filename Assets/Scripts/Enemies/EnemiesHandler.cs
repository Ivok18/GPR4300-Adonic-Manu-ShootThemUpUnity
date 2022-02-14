using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemiesHandler : MonoBehaviour
{
    [SerializeField] public Button buttonForNextEnemy;

    private void Update()
    {
        if(transform.childCount<=0)
        {
            SceneManager.LoadScene("Win");
        }
    }

    public void BringNextEnemy()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        buttonForNextEnemy.gameObject.SetActive(false);
    }
}
