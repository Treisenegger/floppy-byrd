using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        Player player = other.GetComponent<Player>();
        if (player)
            player.IncScore(1);
    }
}
