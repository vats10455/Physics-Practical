using UnityEngine;
using System.Collections;

public class TouchControl : MonoBehaviour
{

    public Rigidbody ball; // Drag your ball here
    private Vector2 fp; // first finger position
    private Vector2 lp; // last finger position

    void Start()
    {
        ball = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                fp = touch.position;
                lp = touch.position;
            }
            if (touch.phase == TouchPhase.Moved)
            {
                lp = touch.position;
            }
            if (touch.phase == TouchPhase.Ended)
            {
                if ((fp.x - lp.x) > 80) // left swipe
                {
                    ball.AddForce(transform.forward * 150f);
                }
                else if ((fp.x - lp.x) < -80) // right swipe
                {
                    ball.AddForce(transform.forward * -150f);

                }

            }
        }
    }
}