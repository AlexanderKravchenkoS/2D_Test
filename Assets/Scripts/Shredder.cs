using UnityEngine;

public class Shredder : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) {
        Destroy(collision.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        var background = collision.GetComponent<Background>();

        if(background != null) {
            Instantiate(background, background.SPAWN_COORDINATES, background.transform.rotation);
        }

        Destroy(collision.gameObject);
    }
}
