using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "MyGame/EnemyData")]
public class EnemyData : ScriptableObject
{
    public GameObject model;
    public float speed;
    public float attackRate;
    public float bulletsSpeed;
    public Color color;

}
