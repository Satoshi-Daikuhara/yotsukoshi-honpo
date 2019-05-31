using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKeyPress_MoveSprite : MonoBehaviour
{
    private float speed = 2;

    float vx = 0;

    float vy = 0;

    bool leftFlag = false;
    Rigidbody2D rbody;

    private void Start()
    {
        // 重力を0にして衝突時に回転させない
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    private void Update()
    {
        vx = 0;
        vy = 0;

        if (Input.GetKey("right"))
        {
            vx = speed;
            leftFlag = false;

        }
        if (Input.GetKey("left"))
        {
            vx = -speed;
            leftFlag = true;

        }
        if (Input.GetKey("up"))
        {
            vy = speed * 10;
        }
        if (Input.GetKey("down"))
        {
            vy = -speed;
        }
    }
    private void FixedUpdate()
    {
        this.transform.Translate(vx / 50, vy / 50, 0);

        this.GetComponent<SpriteRenderer>().flipX = leftFlag;
    }
}
