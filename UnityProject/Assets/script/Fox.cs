using System;
using System.Collections;
using UnityEngine;

public class Fox : MonoBehaviour
{
    [Header("移動速度"), Range(0.1f, 50f)]
    public float Speed=0.1f;
    [Header("剛體 Rigidbody2D")]
    public Rigidbody2D rig;
    [Header("圖片渲染器 SpriteRenderer")]
    public SpriteRenderer Spr;
   

    private void Move()
    {
       
    }

    void Start()
    {
      
    }

    void Update()
    {
        print("狐狸的移動速度" + Speed);
        print(Input.GetAxisRaw("Horizontal"));

        float move = Input.GetAxisRaw("Horizontal");

        rig.AddForce(new Vector2(Speed * move, 0), ForceMode2D.Force);

        if (Input.GetKeyDown("space"))
        {

            rig.AddForce(new Vector2(0, 15), ForceMode2D.Impulse);
            print("fox jump");

        }


        if (move > 0)
        {
            Spr.flipX = false;
        }

        else if (move < 0)
        {
            Spr.flipX = true;
        }
    }
}