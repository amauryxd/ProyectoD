using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkelDamage : MonoBehaviour
{
    [SerializeField] private int damage;
    public Animator animacion;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("toco al jugador");
            other.gameObject.GetComponent<PlayerLife>().Danio(damage);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            //Debug.Log("vida1: " + PlayerLife.vidaP);

           // Debug.Log("toco al jugador");
            // other.gameObject.GetComponent<PlayerLife>().Danio(damage);
            PlayerLife.vidaP = PlayerLife.vidaP - damage;
            //Debug.Log("vida2: " + PlayerLife.vidaP);
        }
    }
}
