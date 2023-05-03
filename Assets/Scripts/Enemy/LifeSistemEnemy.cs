using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSistemEnemy : MonoBehaviour
{
    [SerializeField] public static float vida;
    private Animator animacion;
    public MovPlat mov;
    public float vidaACT;


    // Start is called before the first frame update
    void Start()
    {
        animacion = GetComponent<Animator>();
        vida = 5;
    }
    
    public void Danio(float damage)
    {
        Debug.Log(vida);
        vida -= damage;
        animacion.SetTrigger("Hit");
        Debug.Log(vida);
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
    /*
    private void Update()
    {


        if (vidaACT != vida)
        {
            animacion.SetTrigger("Hit");
            Debug.Log(vida);
            vidaACT = vida;
        }
        if (vida <= 0)
        {
            Muerte();
        }
    }*/

}
