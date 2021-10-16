using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        Player player = other.GetComponent<Player>();
        player.TouchedFloor();
    }
}
