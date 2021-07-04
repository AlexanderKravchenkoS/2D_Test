using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public float points = 0;

    private void Update() {
        points += Time.deltaTime * 5;
    }

    private void OnDestroy() {
        points = 0;
    }
}