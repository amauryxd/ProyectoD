using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Magic : MonoBehaviour
{
    public static int fruID;
    public int ataq=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public static void getID()
    {
        fruID = PowerUP.getFruitID;
        Debug.Log(fruID);
    }
    // Update is called once per frame
    void Update()
    {
        if(fruID == 0)
        {
            
        }
        else
        {
            if(fruID == 1)
            {
                fruID = 0;
                Manzana();
                return;
            }
            if (fruID == 2)
            {
                fruID = 0;
                Limon();
                
                return;
            }
            if (fruID == 3)
            {
                fruID = 0;
                Dragon();
                
                return;
            }
        }
    }

    public void Manzana()
    {
        ataq = 3;
    }

    public void Limon()
    {
        ataq = 5;
    }
    public void Dragon()
    {
        ataq = 7;
    }

    public void magicc(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if(ataq == 0)
            {
                Debug.Log("presiono sin poder");
            }
            else
            {
                magicProyectile.FIRE();
                ataq -= 1;
            }

        }
    }
}
