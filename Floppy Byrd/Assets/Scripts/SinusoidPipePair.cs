using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinusoidPipePair : PipePair
{
    [SerializeField] float verticalRange = 1f;
    [SerializeField] float verticalSpeed = 1f;

    float initialPos;

    private void Start() {
        initialPos = transform.position.y;
    }

    protected override void Update()
    {
        base.Update();
        transform.position = new Vector2(transform.position.x, initialPos + verticalRange * Mathf.Sin(initialPos + verticalSpeed * Time.time));
    }
}
