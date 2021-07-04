using scoreCounter;
using UnityEngine;
using UnityEngine.UI;

namespace ui {
    public class UiController : MonoBehaviour {
        [SerializeField]
        private Text scoreText;

        [SerializeField]
        private ScoreCounter scoreCounter;

        private void Update() {
            scoreText.text = Mathf.Round(scoreCounter.points).ToString();
        }
    }
}

