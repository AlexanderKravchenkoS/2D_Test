using player;
using UnityEngine;

namespace enemy {
    public class Eagle : MonoBehaviour {

        [SerializeField]
        private float speed;

        [SerializeField]
        private float stopDistance;

        [SerializeField]
        private float speedMultiplier;

        private Player player;

        private Vector3 direction;
        private bool isDirectionCounted;

        private void Start() {
            isDirectionCounted = false;
            player = FindObjectOfType<Player>();
        }

        private void Update() {

            if (player == null) {
                return;
            }

            var distanceToPlayer = transform.position.x - player.transform.position.x;
            var playerY = player.transform.position.y;

            if (stopDistance < distanceToPlayer || playerY > transform.position.y) {
                transform.Translate(Vector2.left * Time.deltaTime * speed);

            } else {

                if (!isDirectionCounted) {
                    direction = (player.transform.position - transform.position).normalized;
                    isDirectionCounted = true;
                }

                transform.Translate(direction * Time.deltaTime * speed * speedMultiplier);
            }
        }
    }
}

