using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float maxSpeed;
    Rigidbody2D rigid;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.gravityScale = 1;
    }
    void Update()
    {
        PlayerMove();
        SpeedLimit();
        StopSliding();
        ChangeGravity();
        GetKey();
    }
    void PlayerMove()
    {
        float move = Input.GetAxisRaw("Horizontal");
        rigid.AddForce(Vector2.right * move, ForceMode2D.Impulse);
    }
    void SpeedLimit()
    {
        if (rigid.linearVelocity.x > maxSpeed)
        {
            rigid.linearVelocity = new Vector2(maxSpeed, rigid.linearVelocity.y);
        }
        else if (rigid.linearVelocity.x < -1 * maxSpeed)
        {
            rigid.linearVelocity = new Vector2(-1 * maxSpeed, rigid.linearVelocity.y);
        }
    }
    void StopSliding()
    {
        if (Input.GetButtonUp("Horizontal"))
        {
            rigid.linearVelocity = new Vector2(0, rigid.linearVelocity.y);
        }
    }
    void ChangeGravity()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (rigid.gravityScale == 1)
            {
                rigid.gravityScale = -1;
            }
            else
            {
                rigid.gravityScale = 1;
            }
        }
    }
    void GetKey()
    {
        if (Key.HaveKey == true)
        {
            this.GetComponent<SpriteRenderer>().material.color = Color.yellow;
        }
    }
}