using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public int damagePoints;

    void Start()
    {
        Destroy(gameObject, lifeTime);
        damagePoints = PersistentData.bulletDamage;
    }

    void Update()
    {
        transform.position += transform.forward * speed;
    }
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            col.gameObject.GetComponent<EnemyHealth>().TakeDamage(damagePoints);
        }
        Destroy(gameObject);
    }
}
