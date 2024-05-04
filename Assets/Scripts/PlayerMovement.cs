using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 3f;
    public Animator anim;
    private bool IsMoving;
    public Animator anim2;
    private bool IsMoving2;
    public GameObject player1;
    public GameObject player2;
   
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)) 
        {
            player1.transform.Translate(Vector2.right * speed * Time.deltaTime);
            IsMoving = true;

            if (IsMoving == true)
            {
                anim.SetBool("IsMoving", true);
            }
            else
            {
                anim.SetBool("IsMoving", false);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player1.transform.Translate(Vector2.left * speed * Time.deltaTime);            
        }
        if (Input.GetKey(KeyCode.D))
        {
            player2.transform.Translate(Vector2.right * speed * Time.deltaTime);
            IsMoving2 = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            player2.transform.Translate(Vector2.left * speed * Time.deltaTime);
            IsMoving2 = true;
        }
        if (IsMoving2 == true)
            {
                anim2.SetBool("IsMoving2", true);
            }
        else
            {
                anim2.SetBool("IsMoving2", false);
            }
    }
}
