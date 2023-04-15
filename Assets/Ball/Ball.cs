using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector2 force;
    private Rigidbody2D rigid;
    private SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ボールをスタートさせる
    public void BallStart()
    {
        rigid.AddForce(force);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        sprite.color = Color.HSVToRGB(Random.Range(0f, 1f), 1f, 1f);
    }
}
