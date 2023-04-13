using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoParallax : MonoBehaviour
{
    [SerializeField] private Vector2 velocidadMovimiento;
    private Vector2 offset;
    private Material material;
    private Rigidbody2D jugador;

    private void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
        jugador = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        offset = (jugador.velocity.x * 0.1f) * velocidadMovimiento * Time.deltaTime;
        material.mainTextureOffset += offset;
    }
}
