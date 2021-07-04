using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;

    [SerializeField]
    private ScoreCounter scoreCounter;

    private void Update() {
        scoreText.text = Mathf.Round(scoreCounter.points).ToString();
    }
}
