using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalManager : MonoBehaviour
{
    public static float PortalID = 0;
    

    // Start is called before the first frame update
    private void Start()
    {
        if(PortalID == 2)
        {
            //GameObject portSpawn = GameObject.FindGameObjectWithTag("Portal");
            
            GameObject Spawn = GameObject.FindGameObjectWithTag("Spawn");
            gameObject.transform.position = Spawn.transform.position;
            PortalID = 0;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
