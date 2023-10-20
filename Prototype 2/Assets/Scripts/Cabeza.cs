using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Constraints;
using UnityEngine;

public class Cabeza : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public float espera;

    public Transform target;
    float x;


    public float horizontalInput;


    // Start is called before the first frame update
    void Start()
    {
        // Antes del frame del juego
    }

    // Update is called once per frame

    IEnumerator Esperar()
    {
        yield return new WaitForSeconds(espera);
    }
    void Update()
    {
        /*
        transform.rotation=x;
        if(horizontalInput==0){
          
             x += Time.deltaTime * speed;
             if(x<(0)){

             transform.Rotate(Vector3.up, Time.deltaTime * speed);
             }
            //transform.rotation = Quaternion.Euler(0,x,0);
        }
       */

        Vector3 relativePos = target.position - transform.position;

        // the second argument, upwards, defaults to Vector3.up
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;


        horizontalInput = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime * speed);

    }
}
