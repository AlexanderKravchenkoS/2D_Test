using UnityEngine;

public class ForceController : MonoBehaviour
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
        if(player == null) {
            return;
        }

        player.AddForce(Vector2.down * gravity);

        var direction = new Vector2(0, Mathf.Sin(arrow.transform.rotation.z * Mathf.Deg2Rad));
        player.velocity =  direction * velocityMultiplier;
    }
}
