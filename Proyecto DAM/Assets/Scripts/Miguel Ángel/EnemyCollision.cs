using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyCollision : MonoBehaviour
{
    public Transform spawnPoint;

    /* private void OnCollisionEnter2D(Collision2D collision)
     {
         if (collision.transform.CompareTag("Player"))
         {
             Debug.Log("Player Damaged");
             collision.gameObject.GetComponent<Animator>().Play("HitPlayer");
             collision.gameObject.GetComponent<Lose>().LoseRender();
         }
     }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Player Damaged");
            //collision.gameObject.GetComponent<Animator>().Play("HitPlayer");
            collision.transform.position = (new Vector2(spawnPoint.position.x, spawnPoint.position.y));
        }
    }
}
