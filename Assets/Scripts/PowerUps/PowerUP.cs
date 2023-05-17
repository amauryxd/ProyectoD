using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUP : MonoBehaviour
{
    [SerializeField] public int fruitID;
    public static int getFruitID;

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
        if (collision.CompareTag("Player"))
        {
            actFruit();
            Magic.getID();
            Destroy(gameObject);
        }
    }
    void actFruit()
    {
        getFruitID = fruitID;
    }
}
