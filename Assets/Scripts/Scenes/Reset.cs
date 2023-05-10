using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    private void Update()
    {
        //if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        //{
        //   SceneManager.LoadScene(2);               
        //}
    }
}
