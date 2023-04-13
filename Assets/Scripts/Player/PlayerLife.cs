using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] private float vidaP;
    private Animator animacion;

    // Start is called before the first frame update
    void Start()
    {
        animacion = GetComponent<Animator>();
    }

    public void Danio(float damage)
    {
        vidaP -= damage;

        if (vidaP <= 0)
        {
            Muerte();
        }
    }
    public void Muerte()
    {
        //animacion.SetTrigger("dai");
        SceneManager.LoadScene(1);
    }
}
