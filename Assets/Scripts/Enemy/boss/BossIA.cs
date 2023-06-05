using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class BossIA : MonoBehaviour
{

    public float speed;
    public GameObject[] puntos;
    private int eleccion;

    [SerializeField] private float coolDown;
    [SerializeField] private float tiSigAcc;

    [SerializeField] private Transform controladorGolpe;
    [SerializeField] private float radioGolpe;
    [SerializeField] private int danioGolpe;

    bool ataco=false;

    public Animator animacion;

    public AudioSource soun;

    public GameObject cinemachine;

    private CinemachineVirtualCamera cinemachineVirtual;

    private CinemachineBasicMultiChannelPerlin cinemachineperlin;

    private float timepoI;

    private float timepoTotal;

    private float intensidadI;

    public float a, b, c;

    bool activo1 = false;
    bool activo2 = false;

    public AudioSource clip2;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("toco al jugador");
            collision.gameObject.GetComponent<PlayerLife>().Danio(danioGolpe);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        cinemachineVirtual = cinemachine.GetComponent<CinemachineVirtualCamera>();
        cinemachineperlin = cinemachineVirtual.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

    }

    public void MoverC(float intensidad, float frecuencia, float tiempo)
    {
        cinemachineperlin.m_AmplitudeGain = intensidad;
        cinemachineperlin.m_FrequencyGain = frecuencia;
        intensidadI = intensidad;
        timepoTotal = tiempo;
        timepoI = tiempo;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timepoI > 0)
        {
            timepoI -= Time.deltaTime;
            cinemachineperlin.m_AmplitudeGain = Mathf.Lerp(intensidadI, 0, 1 - (timepoI / timepoTotal)); 
        }

        if(tiSigAcc > 0 )
        {
            tiSigAcc -= Time.deltaTime;
        }

        if (tiSigAcc <= 0)
        {
            eleccion = Random.Range(1, 6);
            ataco = false;
            tiSigAcc = coolDown;
        }

        if(!(LifeSistemEnemy.vida > 25))
        {
            if (!activo1) {
                clip2.Play();
                MoverC(a, b, c);
                activo1 = true;
            }

            coolDown = 4;
            speed = 11;
        }

        
        if (!(LifeSistemEnemy.vida > 7))
        {

            if (!activo2)
            {
                clip2.Play();
                MoverC(a, b, c);
                activo2 = true;
            }

            coolDown = 2;
            speed = 15;
        }

        switch (eleccion)
            {
            
                case 1:
                    transform.position = Vector3.MoveTowards(transform.position, puntos[0].transform.position, speed * Time.deltaTime);
                animacion.SetBool("mov", true);
                if (Random.Range(0,2) == 0 && !ataco && transform.position == puntos[0].transform.position) {
                    
                    Golpe();
                }
                if(transform.position == puntos[0].transform.position)
                {
                    animacion.SetBool("mov", false);
                }
                    break;
                case 2:
                    transform.position = Vector3.MoveTowards(transform.position, puntos[1].transform.position, speed * Time.deltaTime);
                transform.rotation = new Quaternion(0, 1, 0, 0);
                animacion.SetBool("mov", true);
                if (Random.Range(0, 2) == 0 && !ataco && transform.position == puntos[1].transform.position)
                {
                    
                    Golpe();
                }
                if (transform.position == puntos[1].transform.position)
                {
                    animacion.SetBool("mov", false);
                }
                break;
                case 3:
                    transform.position = Vector3.MoveTowards(transform.position, puntos[2].transform.position, speed * Time.deltaTime);
                transform.rotation = new Quaternion(0, 1, 0, 180);
                animacion.SetBool("mov", true);
                if (Random.Range(0, 2) == 0 && !ataco && transform.position == puntos[2].transform.position)
                {
                    
                    Golpe();
                }
                if (transform.position == puntos[2].transform.position)
                {
                    animacion.SetBool("mov", false);
                }
                break;
                case 4:
                    transform.position = Vector3.MoveTowards(transform.position, puntos[3].transform.position, speed * Time.deltaTime);
                transform.rotation = new Quaternion(0, 1, 0, 180);
                animacion.SetBool("mov", true);
                if (Random.Range(0, 2) == 0 && !ataco && transform.position == puntos[3].transform.position)
                {
                    
                    Golpe();
                }
                if (transform.position == puntos[3].transform.position)
                {
                    animacion.SetBool("mov", false);
                }
                break;
                case 5:
                    transform.position = Vector3.MoveTowards(transform.position, puntos[4].transform.position, speed * Time.deltaTime);
                transform.rotation = new Quaternion(0, 1, 0, 0);
                animacion.SetBool("mov", true);
                if (Random.Range(0, 2) == 0 && !ataco && transform.position == puntos[4].transform.position)
                {
                    
                    Golpe();

                }
                if (transform.position == puntos[4].transform.position)
                {
                    animacion.SetBool("mov", false);
                }
                break;
            default:
                Debug.Log("ora que apso");
                break;

            }
            
    }
    void Golpe()
    {


        Collider2D[] objetos = Physics2D.OverlapCircleAll(controladorGolpe.position, radioGolpe);
        foreach (Collider2D colisionador in objetos)
        {
            if (colisionador.CompareTag("Player"))
            {
                //animacionE.SetTrigger("Hit");
                //LifeSistemEnemy.vida = LifeSistemEnemy.vida - danioGolpe;
                animacion.SetTrigger("atac");
                soun.Play();
                colisionador.transform.GetComponent<PlayerLife>().Danio(danioGolpe);
                ataco = true;

            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(controladorGolpe.position, radioGolpe);
    }
}
