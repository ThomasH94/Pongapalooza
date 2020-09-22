using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// The purpose of this class is to update our score by adding or removing from our value
/// This script only needs the text to update, it dosen't care about any other text
/// </summary>
namespace Pongapalooza
{
    public class UpdateScore : MonoBehaviour
    {
        public TextMeshProUGUI scoreText;
        public int score;
        private const int MAX_SCORE_LIMIT = 9999;
        
        // Start is called before the first frame update
        void Start()
        {
            ResetScore();
        }

        public void IncreaseScore()
        {
            score++;
            if(score > MAX_SCORE_LIMIT)
            {
                score = MAX_SCORE_LIMIT;
            }
            scoreText.text = score.ToString();
        }

        public void DecreaseScore()
        {
           score--;
            if(score < 0)
            {
                score = 0;
            }
            scoreText.text = score.ToString();
        }

        void ResetScore()
        {
            score = 0;
            scoreText.text = score.ToString();
        }
    }   
}