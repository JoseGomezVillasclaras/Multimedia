using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestruirInstancia : MonoBehaviour
{
    // Start is called before the first frame update
    float limiteSuperior = 30;
    float LimiteInferior = -10;
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if (transform.position.z>limiteSuperior || 
            transform.position.z<LimiteInferior)
        {
            Destroy(gameObject);


        }
        
    }
}

