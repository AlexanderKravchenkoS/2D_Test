using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShredder : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) {
        var player = collision.gameObject.GetComponent<Player>();
        if(player != null) {
            Destroy(collision.gameObject);
        }
    }
}
