using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private SceneLoader sceneLoader;

    private void OnDestroy() {
        sceneLoader.Restart();
    }
}
