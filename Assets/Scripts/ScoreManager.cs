using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace MarcyShooter{
    public class ScoreManager : MonoBehaviour
    {
        
        public static int score;
        Text text;

        void Start()
        {
            text = GetComponent<Text>();
            score = 0;
        }

        
        void Update()
        {
            text.text = "Score: " + score;
        }
    }
}
