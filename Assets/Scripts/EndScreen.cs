using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    ScoreKeeper scoreKeeper;
    [SerializeField] TextMeshProUGUI scoreRank;
    string scoreText;

    void Awake()
    {
        scoreKeeper = FindAnyObjectByType<ScoreKeeper>();
    }

    public void ShowFinalScore()
    {
        int score = scoreKeeper.correctAnswers;

        if (score < 5)
        {
            scoreText = "You are a...\nPolish Peasant";
        }
        else if (score > 5 && score < 11)
        {
            scoreText = "You are a polish\nPolish Knight!";
        }
        else if (score > 10 && score < 15)
        {
            scoreText = "You are a polish\nPolish Noble!!";
        }
        else if (score == 15)
        {
            scoreText = "You are a polish\nPolish King!!!";
        }  
        
        
        
        finalScoreText.text = "Congratulations!\nYou got a score of " + 
                                scoreKeeper.calculateScore() + "%";
        
        scoreRank.text = scoreText;



        // if (score < 5)
        // {
        //     scoreRank.text = "You are a...\nPolish Peasant";
        // }
        // else if (score > 5 && score < 11)
        // {
        //     scoreRank.text = "You are a polish\nPolish Knight!";
        // }
        // else if (score > 10 && score < 15)
        // {
        //     scoreRank.text = "You are a polish\nPolish Noble!!";
        // }
        // else if (score == 15)
        // {
        //     scoreRank.text = "You are a polish\nPolish King!!!";
        // }
    }

}
