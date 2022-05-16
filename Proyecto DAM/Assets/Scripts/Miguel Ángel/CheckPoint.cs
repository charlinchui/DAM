using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public GameObject checkPoint;

    public void Start()
    {
        checkPoint = GameObject.FindGameObjectWithTag("CheckPoints");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            checkPoint.transform.position = (new Vector2(this.transform.position.x, this.transform.position.y));
        }
    }
}
