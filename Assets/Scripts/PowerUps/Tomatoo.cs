using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomatoo : MonoBehaviour
{
    [SerializeField] public float vel;
    [SerializeField] public float danio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * vel * Time.deltaTime);
        //Debug.Log("danio: "+danio);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            collision.transform.GetComponent<LifeSistemEnemy>().Danio(danio);
        }
    }
}
