using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public int jumpHeight;
void OnTriggerEnter(Collider other) 
{
    if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpHeight);
        }
}
}
