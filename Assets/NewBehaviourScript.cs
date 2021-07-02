using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D player;

    [SerializeField]
    private GameObject arrow;

    [SerializeField]
    private float gravity;
    [SerializeField]
    private float velocityMultiplier;

    private void FixedUpdate() {
        player.AddForce(Vector2.down * gravity);

        player.velocity = new Vector2(0, Mathf.Sin(arrow.transform.rotation.z * Mathf.Deg2Rad)) * velocityMultiplier;
    }
}
