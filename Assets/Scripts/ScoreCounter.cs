using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public int points = 0;

    private void Update() {
        points = (int)Time.realtimeSinceStartup;
    }
}
