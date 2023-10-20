using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;

public class NewBehaviourScript : MonoBehaviour
{


    public float speed;
    public float turnSpeed;

    public GameObject cabeza;
    public Rigidbody coche;
    public float horizontalInput;
    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        // Antes del frame del juego
    }

    // Update is called once per frame

    IEnumerator Esperar(){
        yield return new WaitForSeconds(2); 
    }
    void Update()
    {
        if(cabeza){
            Esperar();
        }
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
            
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime * speed);

        


    }
}
