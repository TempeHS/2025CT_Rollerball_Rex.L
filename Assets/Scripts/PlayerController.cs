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
private Rigidbody PlayerRB; 
private int count;
private float movementX;
private float movementY;
public float jumpHeight;    

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

    void Update(InputValue jumpValue) 
    {
        Vector3 jumping = new Vector3 (0, jumpHeight, 0;);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerRB.AddForce(jumpHeight);
        }
    }
    
    void SetCountText() 
    {
        countText.text =  "Count: " + count.ToString();
        if (count >= 11)
        {
            winTextObject.SetActive(true);
            Destroy(GameObject.FindGameObjectWithTag("Enemy"));
        }
    }
    private void FixedUpdate() 
    {
        Vector3 movement = new Vector3 (movementX, 0.0f, movementY);

        PlayerRB.AddForce(movement * speed); 
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
