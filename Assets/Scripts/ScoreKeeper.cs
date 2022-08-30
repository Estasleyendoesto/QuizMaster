using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int correctAnswers = 0;
    int questionsSeen  = 0;

    public int GetCorrectAnswers()
    {
        return correctAnswers;
    }

    public void IncrementCorrectAnswers()
    {
        correctAnswers++;
    }

    public int GetQuestionsSeen()
    {
        return questionsSeen;
    }

    public void IncrementQuestionsSeen()
    {
        questionsSeen++;
    }

    public int CalculateScore()
    {
        // Si tenemos 10 preguntas, respondimos correctamente 4 y hemos visto 8
        // Entonces sería 4/8 = 50%
        // Si hemos visto 9 sería 4/9 = 44%
        // Si menos visto 10 sería 4/10 = 40%
        return Mathf.RoundToInt(correctAnswers / (float)questionsSeen * 100);
    }
}
