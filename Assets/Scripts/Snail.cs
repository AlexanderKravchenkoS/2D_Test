using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snail : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float speedMultiplier;

    [SerializeField]
    private float jumpStrength;

    private float jumpTime;

    [SerializeField]
    private float minJumpTime;
    [SerializeField]
    private float maxJumpTime;

    [SerializeField]
    private Animator animator;

    public bool isOnGround;

    private new Rigidbody2D rigidbody2D;

    private void Start() {
        jumpTime = Time.time + Random.Range(minJumpTime,maxJumpTime);
        rigidbody2D = GetComponent<Rigidbody2D>();

    }

    private void Update() {
        if(Time.time >= jumpTime) {
            rigidbody2D.AddForce(Vector2.up * jumpStrength);
            jumpTime = Time.time + Random.Range(minJumpTime, maxJumpTime);
        }
        rigidbody2D.AddForce(Vector2.left * speed);
    }

}
