using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    [SerializeField] private Animator animacion;
    [SerializeField] private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.x > 0.1 || rb.velocity.x < -0.1)
        {
            animacion.SetBool("isWalk", true);
        }
        else
        {
            animacion.SetBool("isWalk", false);
        }
    }
}
