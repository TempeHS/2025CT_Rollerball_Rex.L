using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;    

public class WallDeath : MonoBehaviour
{

    public GameObject loseTextObject;
    public GameObject winTextObject;

    void Start()
    {
        winTextObject.SetActive(false);
    }

    void OnTriggerEnter(Collision collision) {

        if(collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
            winTextObject.gameObject.SetActive(true);
            winTextObject.GetComponent<TextMeshProUGUI>().text = "You lose!";
        }
    }
}
