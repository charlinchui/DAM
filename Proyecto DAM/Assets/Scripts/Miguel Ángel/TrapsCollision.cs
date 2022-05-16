using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapsCollision : MonoBehaviour
{
    public GameObject checkPoint;

    public void Start()
    {
        checkPoint = GameObject.FindGameObjectWithTag("CheckPoints");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Player Damaged");
            //collision.gameObject.GetComponent<Animator>().Play("HitPlayer");
            collision.transform.position = (new Vector2(checkPoint.transform.position.x, checkPoint.transform.position.y));
        }
    }
}
