using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private SceneLoader sceneLoader;

    private void OnCollisionEnter2D(Collision2D collision) {
        Destroy(gameObject);
    }

    private void OnDestroy() {
        sceneLoader.Restart();
    }
}
