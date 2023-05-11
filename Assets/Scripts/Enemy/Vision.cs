using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            WayPointMove.isTouch = true;
        }
        else
        {
            WayPointMove.isTouch = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        WayPointMove.isTouch = false;
    }
}
