using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] Image timerImage;

    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;

    public bool isAnsweringQuestion = false;
    public bool loadNextQuestion;
    float timerValue;



    void Update()
    {
        UpdateTimer();
    }


    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;
        
        

        if (timerValue > 0)
        {
            if (isAnsweringQuestion)
            {
                timerImage.fillAmount = timerValue / timeToCompleteQuestion;
            }
            else
            {
                timerImage.fillAmount = timerValue / timeToShowCorrectAnswer;
            }
            
        }


        if (isAnsweringQuestion)
        {

            if (timerValue <= 0)
            {
                isAnsweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
            }

        }
        else
        {
            if (timerValue <= 0)
            {
                isAnsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
            }
        }

    }
}
