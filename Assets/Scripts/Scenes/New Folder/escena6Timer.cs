using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class escena6Timer : MonoBehaviour
{
    public float time = 1000;

    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time -= Time.deltaTime;   

        if(time < 990)
        {
            text1.SetActive(true);
        }

        if (time < 977)
        {
            text2.SetActive(true); 
        }

        if (time < 965)
        {
            text3.SetActive(true); 
        }

        if (time < 950)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
