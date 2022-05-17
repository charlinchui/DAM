using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GruntScript : MonoBehaviour
{
    public Transform John;
    public GameObject EnemyBulletPrefab;

    private int Health = 3;
    private float LastShoot;

    private float distanceToPlayer;
    public int directionLooking = 1; //-1 = izquierda || 1 = derecha

    public int directionToTest;

    void Update()
    {
        if (John == null) return;

        distanceToPlayer = Mathf.Abs(John.position.x - transform.position.x);

        if (John.position.x < transform.position.x)
            directionToTest = -1;
        else
            directionToTest = 1;

        if (distanceToPlayer > 1.0f || directionLooking != directionToTest)
        {
            transform.position = new Vector2(transform.position.x + 0.5f * directionLooking * Time.deltaTime, transform.position.y);
        }
        else
        {
            if (Time.time > LastShoot + 01.0 && directionLooking == directionToTest)
            {
                Shoot();
                LastShoot = Time.time;
            }
        }
    }

    private void Shoot()
    {
        Vector3 direction = new Vector3(transform.localScale.x, 0.0f, 0.0f);
        GameObject bullet = Instantiate(EnemyBulletPrefab, transform.position + direction * 0.1f, Quaternion.identity);
        bullet.GetComponent<EnemyBulletScript>().SetDirection(direction);
    }

    public void Hit()
    {
        Health -= 1;
        if (Health == 0) Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (directionLooking == 1)
        {
            directionLooking = -1;
            transform.localScale = new Vector3(directionLooking, 1.0f, 1.0f);
        }
        else
        {
            directionLooking = 1;
            transform.localScale = new Vector3(directionLooking, 1.0f, 1.0f);
        }
            
    }
}