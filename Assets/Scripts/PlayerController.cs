using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;


public class PlayerController : MonoBehaviour
{
public GameObject winTextObject;
public GameObject loseTextObject;
public float speed = 0;
public TextMeshProUGUI countText; 
private Rigidbody rb; 
private int count;
private float movementX;
private float movementY;
    void Start()
    {
        winTextObject.SetActive(false);
        rb = GetComponent <Rigidbody>(); 
        count = 0; 
        SetCountText();
    }
    void OnMove (InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>(); 
        movementX = movementVector.x; 
        movementY = movementVector.y; 
    }
    
    void SetCountText() 
    {
        countText.text =  "Count: " + count.ToString();
        if (count >= 11)
<<<<<<< Updated upstream
       {
           winTextObject.SetActive(true);
           Destroy(GameObject.FindGameObjectWithTag("Enemy"));
       }
       
=======
        {
            winTextObject.SetActive(true);
        }
>>>>>>> Stashed changes
    }
    private void FixedUpdate() 
    {
        Vector3 movement = new Vector3 (movementX, 0.0f, movementY);

        rb.AddForce(movement * speed); 
    }

<<<<<<< Updated upstream
   void OnTriggerEnter(Collider other) 
   {
           if (other.gameObject.CompareTag("PickUp")) 
       {
         other.gameObject.SetActive(false);
         count = count + 1;
         SetCountText();
       }
   }

   private void OnCollisionEnter(Collision collision)
   {
    if(collision.gameObject.CompareTag("Enemy"))
    {
        Destroy(gameObject);
        winTextObject.gameObject.SetActive(true);
        winTextObject.GetComponent<TextMeshProUGUI>().text = "You lose!";
    }
   }
=======
    void OnTriggerEnter(Collider other) 
    {
            if (other.gameObject.CompareTag("PickUp")) 
        {
        other.gameObject.SetActive(false);
        count = count + 1;
        SetCountText();
        }
    }
>>>>>>> Stashed changes
}
