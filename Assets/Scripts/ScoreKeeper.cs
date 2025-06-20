using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public int correctAnswers = 0;
    int questionsSeen = 0;

    public int getCorrectAnswers()
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

    public int calculateScore()
    {
        return Mathf.RoundToInt(correctAnswers / (float)questionsSeen * 100);
    }
}
