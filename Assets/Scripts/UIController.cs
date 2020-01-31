﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
  int score = 0;
  GameObject scoreText;
  GameObject gameOverText;

  public void AddScore()
  {
    this.score += 10;
  }

  public void GameOver()
  {
    this.gameOverText.GetComponent<Text>().text = "GameOver";
  }
  // Start is called before the first frame update
  void Start()
  {
    this.scoreText = GameObject.Find("Score");
    this.gameOverText = GameObject.Find("GameOver");
  }

  // Update is called once per frame
  void Update()
  {
    scoreText.GetComponent<Text>().text = "Score:" + score.ToString("D4");
  }
}
