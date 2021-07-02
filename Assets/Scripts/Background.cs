using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField]
    private float speed;

    public readonly Vector3 SPAWN_COORDINATES = new Vector3(18.5f, 0, 0);

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
    }

}
