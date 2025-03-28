using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextController : MonoBehaviour
{
    public PlayerController PlayerController;
    public GameObject winTextObject;
    public GameObject loseTextObject;
    public TextMeshProUGUI countText; 
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
