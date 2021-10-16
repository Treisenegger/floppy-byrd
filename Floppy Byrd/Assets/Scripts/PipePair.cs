using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePair : MonoBehaviour
{
    [SerializeField] protected float pipeSpeed = 5f;

    protected virtual void Update() {
        transform.Translate(new Vector2(-pipeSpeed * Time.deltaTime, 0f));
    }

    public void TouchedDespawner() {
        Destroy(gameObject);
    }
}
