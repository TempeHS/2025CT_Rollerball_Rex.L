using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public bool activated = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void onTriggerEnter(Collider other) {
        Player.GetComponent().AddForce(Vector3.up * AmountOfForce)
    }

    void Update()
    {
        
    }
}
