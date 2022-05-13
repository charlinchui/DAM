using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallCollider : MonoBehaviour
{
    public Transform spawnPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.transform.position = (new Vector2(spawnPoint.position.x, spawnPoint.position.y));
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }

}
