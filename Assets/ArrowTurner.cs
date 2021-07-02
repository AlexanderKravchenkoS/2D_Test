using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowTurner : MonoBehaviour
{

    [SerializeField]
    private GameObject arrow;

    private void Update()
    {
        if(Input.touchCount <= 0) {
            return;
        }

        if (Input.touches[0].phase == TouchPhase.Began) {
            var point = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            point.z = 0;
            var direction = (point - arrow.transform.position).normalized;
            arrow.transform.localEulerAngles = new Vector3(0, 0, Vector3.Angle(new Vector3(1,0,0), direction));
        }
    }
}
