using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator thisAnim;
    private Rigidbody2D rigid;
    public LayerMask whatIsGround;
    public Vector3 speed = new Vector3(1, 1, 1);
    // Start is called before the first frame update
   

    void Start()
    {
        thisAnim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Martin")
        {
            thisAnim.SetTrigger("Hit");
            thisAnim.SetBool("Naked",true);

        }
        if (other.gameObject.name == "PickUpShell" && thisAnim.GetBool("Naked"))
        {
            thisAnim.SetTrigger("Heal");
            Destroy(other.gameObject);

        }
    }
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(speed.x * h * 3, 0, 0);
        movement *= Time.deltaTime;
        thisAnim.SetFloat("Speed", Mathf.Abs(h));

        if (h < 0.0)
        {
            transform.localScale = new Vector3(-6, 6, 1);
            transform.Translate(movement);
        }
        else if (h > 0.0)
        {
            transform.localScale = new Vector3(6, 6, 1);
            transform.Translate(movement);
        }

        if (Input.GetButtonDown("Horizontal"))
        {
            thisAnim.SetTrigger("Walk");
        }
      


    }
}
