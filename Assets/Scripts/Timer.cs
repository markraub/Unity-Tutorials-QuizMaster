using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{


    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;

    public bool isAnsweringQuestion = false;
    public bool loadNextQuestion;
    float timerValue;
    public float timerFraction;



    void Update()
    {
        UpdateTimer();
    }


    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;
        
        

        if (isAnsweringQuestion)
        {
            
            if (timerValue > 0) 
            {
                
                timerFraction = timerValue / timeToCompleteQuestion;
            }
            else 
            {
                isAnsweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
            }

        }
        else 
        {
            if (timerValue > 0) 
            {
                timerFraction = timerValue / timeToShowCorrectAnswer;
            }
            else {
                isAnsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
                loadNextQuestion = true;
            }
        }
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }
}
