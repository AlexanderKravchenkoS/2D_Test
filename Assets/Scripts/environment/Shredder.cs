using UnityEngine;

namespace environment {
    public class Shredder : MonoBehaviour {

        private void OnCollisionEnter2D(Collision2D collision) {
            Destroy(collision.gameObject);
        }

        private void OnTriggerEnter2D(Collider2D collision) {
            var background = collision.GetComponent<Background>();

            if (background != null) {
                var pos = background.SPAWN_COORDINATES;
                var rot = background.transform.rotation;
                Instantiate(background, pos, rot);
            }

            Destroy(collision.gameObject);
        }
    }
}

