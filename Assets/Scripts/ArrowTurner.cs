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

        if (Input.touches[0].phase == TouchPhase.Moved) {
            var point = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            point.z = 0;
            var direction = (point - arrow.transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            angle = Mathf.Clamp(angle, -90f, 90f);
            arrow.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
}
