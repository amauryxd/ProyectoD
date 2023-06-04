using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collIamge : MonoBehaviour
{

    public GameObject si;
    public GameObject back;
    public Animator audio2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        back = GameObject.FindGameObjectWithTag("Music");
        audio2 = back.GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        si.SetActive(true);
        audio2.enabled = true;
    }
}
