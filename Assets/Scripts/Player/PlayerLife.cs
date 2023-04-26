using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] public static float vidaP=100;
    [SerializeField] private Animator animacion;
    public float vidaACT;

    // Start is called before the first frame update
    void Start()
    {
        //animacion = GetComponent<Animator>();
        //vidaP = 100;
        vidaACT = vidaP;

        if (PlayerPrefs.HasKey("Health"))
        {
            vidaP = PlayerPrefs.GetInt("Health");
        }
    }

    public void Danio(float damage)
    {
        vidaP -= damage;
        PlayerPrefs.SetFloat("Health", vidaP);
        if (vidaP <= 0)
        {
            Muerte();
        }
    }
    public void Muerte()
    {
        //animacion.SetTrigger("dai");
        PlayerPrefs.DeleteAll();
        vidaP = 100;
        SceneManager.LoadScene(1);
        
    }
    public void Guardar()
    {
        vidaACT = vidaP;
    }
    private void Update()
    {

        if (vidaACT != vidaP)
        {
            animacion.SetTrigger("Hit");
            Debug.Log(vidaP);
            vidaACT = vidaP;
        }
        if (vidaP <= 0)
        {
            Muerte();
        }
    }
}
