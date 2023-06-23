using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour
{

    [SerializeField] private LineRenderer _line;
    [SerializeField] private Camera _camera;

    private int count = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _line.positionCount = 0;
            count = 0;
        }
        if (Input.GetMouseButton(0))
        {
            var mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5);
            var drewingPosition = _camera.ScreenToWorldPoint(mousePosition);
            _line.positionCount++;
            _line.SetPosition(count,drewingPosition);
            count++;

        }
    }
}
