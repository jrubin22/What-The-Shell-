using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MartinJump : MonoBehaviour
{
    [SerializeField] private LayerMask groundLayerMask;
    private Animator thisAnim;
    private Rigidbody2D rigid;
    private BoxCollider2D collide;
    public float jumpForce = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rigid = transform.GetComponent<Rigidbody2D>();
        collide = transform.GetComponent<BoxCollider2D>();
        thisAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsGrounded()) //&& Input.GetKeyDown(KeyCode.Space))
        {

            rigid.velocity = Vector2.up * jumpForce;

        }

    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2D = Physics2D.BoxCast(collide.bounds.center, collide.bounds.size, 0f, Vector3.down, 0.01f, groundLayerMask );
        Debug.Log(raycastHit2D.collider); 
        return (raycastHit2D.collider != null);

    }
}