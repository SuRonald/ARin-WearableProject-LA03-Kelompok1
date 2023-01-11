using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateInput : MonoBehaviour
{
    public float rotatespeed;
    private float startingPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startingPosition = touch.position.y;
                    Debug.Log(startingPosition);
                    Debug.Log("Touch Phase Began.");
                    break;
                case TouchPhase.Moved:
                    Debug.Log(touch.position.x);
                    if (startingPosition > touch.position.y)
                    {
                        transform.Rotate(Vector3.left, rotatespeed * Time.deltaTime, Space.World);
                    }
                    else if (startingPosition < touch.position.y)
                    {
                        transform.Rotate(Vector3.right, rotatespeed * Time.deltaTime, Space.World);
                    }
                    Debug.Log(touch.position.y);
                    Debug.Log("Touch Phase Moved.");
                    break;
                case TouchPhase.Ended:
                    Debug.Log("Touch Phase Ended.");
                    break;
            }
        }
    }
}
