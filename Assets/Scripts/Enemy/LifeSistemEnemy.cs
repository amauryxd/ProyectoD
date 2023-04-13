using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSistemEnemy : MonoBehaviour
{
    [SerializeField] private float vida;
    private Animator animacion;
    public MovPlat mov;

    // Start is called before the first frame update
    void Start()
    {
        animacion = GetComponent<Animator>();
    }

    public void Danio(float damage)
    {
        vida -= damage;
       
        if (vida <= 0)
        {
            Muerte();
        }
    }
    public void Muerte()
    {
        //animacion.SetTrigger("ded");
        //mov.enabled = false;
        Destroy(gameObject);
    }
   
}
