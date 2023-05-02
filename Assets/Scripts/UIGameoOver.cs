using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIGameoOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    ScoreKeeper scoreKeeper;

     void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }


     void Start()
    {
        scoreText = "You Scored:\n" + scoreKeeper.GetScore();
    }
}
