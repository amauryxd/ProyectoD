using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointMove : MonoBehaviour
{
    [SerializeField] private Transform[] puntosMov;
    [SerializeField] private float velocidadMov;
    private int sigPlatf = 1;
    private bool ordenPtalf = true;
    [SerializeField] GameObject ojo;
    public static bool isTouch;
    [SerializeField] GameObject play;

    

    private void Update()
    {
        if (!isTouch)
        {
            movPlat();
        }
        else
        {
            //transform.Translate(Vector3.left * (velocidadMov+1) * Time.deltaTime);
            // transform.Translate(Vector3.down * (velocidadMov-1) * Time.deltaTime * 0.1f);
            if (Mathf.Abs(transform.position.x - play.transform.position.x) > 0.1 || Mathf.Abs(transform.position.y - play.transform.position.y) > 0.1) //Si la distancia es mayor al rango de ataque, significa que se tiene que acercar
            {
                if (transform.position.x < play.transform.position.x)
                {

                    transform.Translate(Vector3.left * (velocidadMov + 1) * Time.deltaTime);
                    transform.Translate(Vector3.down * (velocidadMov + 1) * Time.deltaTime * 0.1f);
                    transform.rotation = Quaternion.Euler(0, 180, 0);

                }
                else
                {

                    transform.Translate(Vector3.left * (velocidadMov + 1) * Time.deltaTime);
                    transform.Translate(Vector3.down * (velocidadMov + 1) * Time.deltaTime * 0.1f);
                    transform.rotation = Quaternion.Euler(0, 0, 0);

                }

            }
        }


    }
    
    void movPlat()
    {
        if (ordenPtalf && sigPlatf + 1 >= puntosMov.Length)
        {
            ordenPtalf = false;
        }
        if (!ordenPtalf && sigPlatf <= 0)
        {
            ordenPtalf = true;
        }
        if (Vector2.Distance(transform.position, puntosMov[sigPlatf].position) < 0.1f)
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
        transform.position = Vector2.MoveTowards(transform.position, puntosMov[sigPlatf].position, velocidadMov * Time.deltaTime);
    }
}
