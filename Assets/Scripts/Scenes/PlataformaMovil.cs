using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaMovil : MonoBehaviour
{
    [SerializeField] private Transform[] puntosMov;
    [SerializeField] private float velocidadMov;
    private int sigPlatf = 1;
    private bool ordenPtalf = true;

    private void Update()
    {
        if(ordenPtalf && sigPlatf + 1 >= puntosMov.Length)
        {
            ordenPtalf = false;
        }
        if(!ordenPtalf && sigPlatf <= 0)
        {
            ordenPtalf = true;
        }
        if(Vector2.Distance(transform.position, puntosMov[sigPlatf].position) < 0.1f)
        {
            if (ordenPtalf)
            {
                sigPlatf += 1;
            }
            else
            {
                sigPlatf -= 1;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, puntosMov[sigPlatf].position, velocidadMov*Time.deltaTime);
    }
}
