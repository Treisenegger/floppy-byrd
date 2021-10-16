using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] float impulseSpeed = 5f;
    [SerializeField] Text scoreText;
    [SerializeField] float minRotationSpeed = -5f;

    Rigidbody2D playerRigidBody;
    int score;

    void Start() {
        playerRigidBody = GetComponent<Rigidbody2D>();
        score = 0;
        UpdateScore();
    }

    void Update() {
        Impulse();
        RotateMouth();
    }

    void Impulse() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            playerRigidBody.velocity = new Vector2(0f, impulseSpeed);
        }
    }

    void Die() {
        Destroy(gameObject);
    }

    public void TouchedFloor() {
        Die();
    }

    public void TouchedPipe() {
        Die();
    }

    public void IncScore(int addedScore) {
        score += addedScore;
        UpdateScore();
    }

    void UpdateScore() {
        scoreText.text = score.ToString();
    }

    void RotateMouth() {
        float t = Mathf.InverseLerp(minRotationSpeed, impulseSpeed, playerRigidBody.velocity.y); // (playerRigidBody.velocity.y - minRotationSpeed) / (impulseSpeed - minRotationSpeed);
        float rotationAngle = Mathf.LerpAngle(-45f, 45f, t);
        transform.eulerAngles = new Vector3(0f, 0f, rotationAngle);
    }

}
