using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMov : MonoBehaviour
{
    public Rigidbody2D rb;
    //public InputAction playerC;
    private Vector2 moveVector;
    public float moveSpeed;
    public float jumpforce;
    public bool isGround;
    public Transform groundSpot;
    public LayerMask groundLayer;
    public bool isfacingR;

    Vector2 moveDir = Vector2.zero;

    public Animator animacion;
    private void OnEnable()
    {
        //playerC.Enable();
    }

    private void OnDisable()
    {
       // playerC.Disable();
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        //cuando se detecte un input de "move" se "leera" el valor del vector 2
        moveVector = context.ReadValue<Vector2>();
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        //si se detecta un input de "jump" checara si el objeto esta en el suelo, si lo esta saltara
        if (context.performed && isGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpforce);
            //variable para animacion de saltar
        }

    }
    public void RunRun(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            moveSpeed = moveSpeed * 1.5f;           
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // moveDir = playerC.ReadValue<Vector2>();
        isGround = Physics2D.OverlapCircle(groundSpot.position, 0.1f, groundLayer);
        //animaciones
        CheckDirection();
        
    }

    private void FixedUpdate()
    {
        // rb.velocity = new Vector2(moveDir.x * moveSpeed,moveDir.y*moveSpeed);   
        rb.velocity = new Vector2(moveVector.x * moveSpeed, rb.velocity.y);
        //correr
        float runCheck = moveVector.x;
        if (runCheck > 0 || runCheck < 0)
        {
            animacion.SetBool("isRun", true);
        }
        if (runCheck == 0)
        {
            animacion.SetBool("isRun", false);
        }
        //saltar
        if (isGround)
        {
            animacion.SetBool("isJump", false);
            animacion.SetBool("isGround", true);
        }
        if (!isGround)
        {
            animacion.SetBool("isJump", true);
            animacion.SetBool("isGround", false);
        }
        if (rb.velocity.y < 0)
        {
            animacion.SetBool("isFall", true);
        }
        if (rb.velocity.y == 0)
        {
            animacion.SetBool("isFall", false);
            animacion.SetBool("isJump", false);
        }
    }
    void CheckDirection()
    {
        if (moveVector.x > 0 && !isfacingR)
        {
            Flip();
            //51:54
        }
        else if (moveVector.x < 0 && isfacingR)
        {
            Flip();
        }
    }
    void Flip()
    {
        isfacingR = !isfacingR;
        transform.Rotate(new Vector3(0, 180, 0));
    }
}
