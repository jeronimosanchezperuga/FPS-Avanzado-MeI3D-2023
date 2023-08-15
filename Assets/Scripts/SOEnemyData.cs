using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "EnemyData",menuName ="Scriptable Objects/Enemy")] 
public class SOEnemyData : ScriptableObject
{
    public int scorePoints;
    public int hitPoints;
    public GameObject model;


}
