using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (Application.isEditor)
        {
            // マウスボタンが押された時
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("On mouse down");
            }

            // マウスボタンが離された時
            if (Input.GetMouseButtonUp(0))
            {
                Debug.Log("On mouse up");
            }

            // マウスボタンが押されている間
            if (Input.GetMouseButton(0))
            {
                Debug.Log("On mouse press");
            }
        }
        else
        {

            if (0 < Input.touchCount)
            {
                UnityEngine.Touch touch = Input.GetTouch(0);

                // 画面タッチした時
                if (touch.phase == TouchPhase.Began)
                {
                    Debug.Log("On touch began");
                }

                // 画面から離れた時
                if (touch.phase == TouchPhase.Ended)
                {
                    Debug.Log("On touch ended");
                }

                // 画面タッチして動かしている間
                if (touch.phase == TouchPhase.Moved)
                {
                    Debug.Log("On touch moved");
                }

                // 画面タッチしたまま動かない間
                if (touch.phase == TouchPhase.Stationary)
                {
                    Debug.Log("On touch stationary");
                }
            }
        }
    }
}
