using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlDeJuego : MonoBehaviour
{
    public void ResetJuego(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
