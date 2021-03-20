using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator thisAnim;
    private Rigidbody2D rigid;
    public LayerMask whatIsGround;
    public Vector3 speed = new Vector3(1, 1, 1);
    int health = 2;
    public Scene scene;

    // Start is called before the first frame update


    void Start()
    {
        thisAnim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Martin")
        {
            health += -1;
            if (health == 1)
            {
                thisAnim.SetTrigger("Hit");
                thisAnim.SetBool("Naked", true);
            }
            if (health == 0)
            {
                this.gameObject.SetActive(false);
                SceneManager.LoadScene(scene.name);
            }
        }
        else if (other.gameObject.name == "PickUpShell" && (health <2))
        {
            health++;
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
