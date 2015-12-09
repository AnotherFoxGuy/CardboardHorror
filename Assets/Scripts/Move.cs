using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
    private bool _touching;

    private void Update()
    {

        if (Input.touchCount != 1)
        {
            _touching = false;
            return;
        }

        var touch = Input.touches[0];

        if (touch.phase == TouchPhase.Began)
        {
            _touching = true;
        }       
        if (_touching && (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled))
        {
            _touching = false;
        }
        if (_touching)
        {
            var s = Vector3.forward*2;
            transform.Translate(s * Time.deltaTime);
        }
    }
}