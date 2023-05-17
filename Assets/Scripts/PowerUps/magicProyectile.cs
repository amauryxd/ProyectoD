using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magicProyectile : MonoBehaviour
{
    [SerializeField] public Transform controladorD;
    [SerializeField] public GameObject maigc;
    public static Transform controlador;
    public static GameObject magic2;

    // Start is called before the first frame update
    void Start()
    {
        controlador = controladorD;
        magic2 = maigc;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void FIRE()
    {
        Instantiate(magic2, controlador.position, controlador.rotation);
    }
}
