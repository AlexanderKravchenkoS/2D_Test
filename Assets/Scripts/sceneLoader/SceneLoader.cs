using UnityEngine;
using UnityEngine.SceneManagement;

namespace sceneLoader {
    public class SceneLoader : MonoBehaviour {

        public void Restart() {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
