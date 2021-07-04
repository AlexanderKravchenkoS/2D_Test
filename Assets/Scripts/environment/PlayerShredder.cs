using player;
using UnityEngine;

namespace environment {
    public class PlayerShredder : MonoBehaviour {

        private void OnCollisionEnter2D(Collision2D collision) {
            var player = collision.gameObject.GetComponent<Player>();

            if (player != null) {
                Destroy(collision.gameObject);
            }
        }
    }
}
