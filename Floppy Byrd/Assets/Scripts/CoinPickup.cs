using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] protected float coinSpeed = 5f;

    private void Update() {
        transform.Translate(new Vector3(-coinSpeed * Time.deltaTime, 0f, 0f));
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Player player = other.GetComponent<Player>();
        if (player) {
            player.IncScore(5);
            Destroy(gameObject);
        }
    }


}
