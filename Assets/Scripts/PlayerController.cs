using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
public TextController textController;
public GameObject winTextObject;
public GameObject loseTextObject;
public float speed = 0;
public TextMeshProUGUI countText; 
public Rigidbody PlayerRB; 
private int count;
private float movementX;
private float movementY;
    

    void Start()
    {
        winTextObject.SetActive(false);
        PlayerRB = GetComponent <Rigidbody>(); 
        count = 0; 
        SetCountText();
    }
    void OnMove (InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>(); 
        movementX = movementVector.x; 
        movementY = movementVector.y; 
    }

    
    
    private void FixedUpdate() 
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (movementX, 0.0f, movementY);

        PlayerRB.AddForce(movement * speed); 

        GetComponent<Rigidbody>().AddForce (movement * speed * Time.deltaTime);


    }
    

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

}
