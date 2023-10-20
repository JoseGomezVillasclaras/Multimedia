using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
public GameObject panel;

    public Text scoreText;
    
    int score=0;

    private void Awake(){
        instance =this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text=score.ToString()+" POINTS";
    }

   
public void AddPoint(){
score+=1;
scoreText.text=score.ToString()+" POINTS";
 if(score==3){
            PauseGame();
            panel.SetActive(true);
        }
}
public void resta(){
score-=1;
scoreText.text=score.ToString()+" POINTS";
}

void PauseGame ()
    {
        Time.timeScale = 0;
    }

}
