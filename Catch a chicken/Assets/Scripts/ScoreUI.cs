using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;

    private void Start()
    {
        GlobalEventManager.OnChickenCatched += SetScoreUI;
    }

    private void SetScoreUI()
    {
        _scoreText.SetText("SCORE: " + FindObjectOfType<GameManager>().PlayerScore.ToString());
    }
}
