using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class VidasPantalla : MonoBehaviour
{
    public TextMeshProUGUI text;
    //[SerializeField] List<Image> life;
    [SerializeField] GameObject[] vidas;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //text.text = PlayerLife.vidaP.ToString();
            int vidd = PlayerLife.vidaP;
        if(vidd < 10)
        {
            vidas[9].SetActive(false);
        }
        if (vidd < 9)
        {
            vidas[8].SetActive(false);
        }
        if (vidd < 8)
        {
            vidas[7].SetActive(false);
        }
        if (vidd < 7)
        {
            vidas[6].SetActive(false);
        }
        if (vidd < 6)
        {
            vidas[5].SetActive(false);
        }
        if (vidd < 5)
        {
            vidas[4].SetActive(false);
        }
        if (vidd < 4)
        {
            vidas[3].SetActive(false);
        }
        if (vidd < 3)
        {
            vidas[2].SetActive(false);
        }
        if (vidd < 2)
        {
            vidas[1].SetActive(false);
        }


    }
}
