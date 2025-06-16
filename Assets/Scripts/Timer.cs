using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float tomeToShowCorrectAnswer = 10f;

    public bool loadNextQuestion;    
    
    public bool isAnseringQuestion;
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

        if (isAnseringQuestion == true)
        {
            if (timerValue >= 0)
            {
                fillFraction = timerValue / timeToCompleteQuestion;
            }
            else
            {
                isAnseringQuestion = false;
                timerValue = tomeToShowCorrectAnswer;
            }
        }
        else
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / tomeToShowCorrectAnswer;
            }
            else
            {
                isAnseringQuestion = true;
                timerValue = timeToCompleteQuestion;
                loadNextQuestion = true;
            }
        }

        if (timerValue <= 0)
        {
            timerValue = timeToCompleteQuestion;
        }
    }
}
