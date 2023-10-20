using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ScoreManager.instance.AddPoint();
              
    }
}
