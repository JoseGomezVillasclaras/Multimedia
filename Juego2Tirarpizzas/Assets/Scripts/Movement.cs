using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
     // Start is called before the first frame update
    public float desplazamientoHorizontal;
    public float velocidad=10f;
    public GameObject ProyectilPrefab;
    public GameObject ProyectilPrefab2;
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        //GetKeyDown significa al pulsar la tecla.. con Keycode
        //le decimos que tecla vamos a usar.
       if (Input.GetKeyDown(KeyCode.Space)) {
            //ahora vamos a realizar instancias o copias del prefab que hemos creado
            //transformm position accedemos a la misma
            //posicion del jugador. con proyectilprefb.transror.rotation le decimos que no queremos ninguna rotacion
            Instantiate(ProyectilPrefab, transform.position,
                ProyectilPrefab.transform.rotation);


        }
        if (Input.GetKeyDown(KeyCode.LeftControl)) {
            //ahora vamos a realizar instancias o copias del prefab que hemos creado
            //transformm position accedemos a la misma
            //posicion del jugador. con proyectilprefb.transror.rotation le decimos que no queremos ninguna rotacion
            Instantiate(ProyectilPrefab2, transform.position,
                ProyectilPrefab2.transform.rotation);


        }


        if(transform.position.x < -20) {
            transform.position = new Vector3(-20,transform.position.y, transform.position.z);
        }
        if(transform.position.x > 20) {
            transform.position = new Vector3(20,transform.position.y, transform.position.z);
        }


        desplazamientoHorizontal = Input.GetAxis("Horizontal");
        //Mover al jugarod horizontalmente
        transform.Translate(Vector3.right * desplazamientoHorizontal * Time.deltaTime * velocidad);


    }
}


