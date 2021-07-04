using UnityEngine;

namespace control {
    public class ForceController : MonoBehaviour {

        [SerializeField]
        private Rigidbody2D playerRb;

        [SerializeField]
        private GameObject arrow;

        [SerializeField]
        private float gravity;

        [SerializeField]
        private float velocityMultiplier;

        private void FixedUpdate() {
            if (playerRb == null) {
                return;
            }

            playerRb.AddForce(Vector2.down * gravity);

            var direction = new Vector2(0, Mathf.Sin(arrow.transform.rotation.z * Mathf.Deg2Rad));
            playerRb.velocity = direction * velocityMultiplier;
        }
    }
}


