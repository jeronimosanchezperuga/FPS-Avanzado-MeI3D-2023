using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        health = PersistentData.enemyHealthPoints;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            //morir
            Death();
        }
        Debug.Log(health);
    }

    private void Death()
    {
        Destroy(gameObject);
        //sonido
        //animacion
        //restar una vida
        //sumar un punto
        scoreManager.AddScore(1);
    }
}
