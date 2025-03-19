using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float maxSpeed;

    Rigidbody2D rigid;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.gravityScale = 1.5F;
    }
    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");
        rigid.AddForce(Vector2.right * move, ForceMode2D.Impulse);
        if (rigid.linearVelocity.x > maxSpeed)
        {
            rigid.linearVelocity = new Vector2(maxSpeed, rigid.linearVelocity.y);
        }
        else if (rigid.linearVelocity.x < -1 * maxSpeed)
        {
            rigid.linearVelocity = new Vector2(-1 * maxSpeed, rigid.linearVelocity.y);
        }
        if (Input.GetButtonUp("Horizontal"))
        {
            rigid.linearVelocity = new Vector2(0, rigid.linearVelocity.y);
        }
        if (Input.GetButtonDown("Jump"))
        {
            if (rigid.gravityScale == 1.5F)
            {
                rigid.gravityScale = -1.5F;
            }
            else{
                rigid.gravityScale = 1.5F;
            }
        }
    }
}
