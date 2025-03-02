using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContact : MonoBehaviour
{
bool isCurrentlyColliding;
public GameObject loseTextObject;

void OnCollisionEnter(Collision col) {
  isCurrentlyColliding = true;
}

void OnCollisionExit(Collision col) {
  isCurrentlyColliding = false;
}

void Update() {
  if (isCurrentlyColliding) {
    loseTextObject.SetActive(true);
  }
}
}
