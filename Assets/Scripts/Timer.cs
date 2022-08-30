using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Se recomienda que el temporizador sea un GameObject global y no hijo de nadie.
*/
public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion;
    [SerializeField] float timeToShowCorrectAnswer;

    public bool loadNextQuestion;
    public bool isAnsweringQuestion;
    public float fillFraction;

    float timerValue;

    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if (isAnsweringQuestion)
        {
            /*
                Si timerValue parte de 5s en total y con -deltaTime pasa de 5 a 0 segundos.
                Si dividimos timerValue entre el tiempo total con el que partió estamos normalizando 5 sengundos en un rango de 0 a 1 en decimales.
                Pero eso solo ocurre si el divisor es mayor al dividendo, recordemos las fracciones 5/10.
            */
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeToCompleteQuestion;
            } 
            else
            {
                timerValue = timeToShowCorrectAnswer;
                isAnsweringQuestion = false;
            }
        } 
        else
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeToShowCorrectAnswer;
            } 
            if (timerValue <= 0)
            {
                timerValue = timeToCompleteQuestion;
                isAnsweringQuestion = true;
                loadNextQuestion = true;
            }
        }

        Debug.Log(isAnsweringQuestion + ": " + timerValue + " = " + fillFraction);
    }
}
