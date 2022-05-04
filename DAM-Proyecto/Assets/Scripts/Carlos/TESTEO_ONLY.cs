using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SWNetwork;

public class TESTEO_ONLY : MonoBehaviour
{
    public float speed;
    NetworkID networkID;
    private void Start() {
        networkID = GetComponent<NetworkID>();
    }
    void FixedUpdate()
    {
        if(networkID.IsMine){
            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");

            float newX = transform.position.x + speed * horizontal * Time.deltaTime;
            float newY = transform.position.y + speed * vertical * Time.deltaTime;

            transform.position = new Vector3 (newX, newY, 0);
        }
    }
}
