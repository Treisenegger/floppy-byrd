using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeDespawner : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        PipePair pipePair = other.GetComponent<PipePair>();
        if (pipePair)
            pipePair.TouchedDespawner();
    }
}
