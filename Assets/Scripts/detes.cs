using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detes : MonoBehaviour
{
    public AudioSource canc;
    public Animator animacionxd;
    public GameObject cam1;
    public GameObject cam2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canc.enabled = true;
        animacionxd.enabled = true;
        cam2.SetActive(true);
        cam1.SetActive(false);
    }
}
