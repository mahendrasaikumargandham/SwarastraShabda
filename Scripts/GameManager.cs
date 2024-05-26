using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Score Settings")]
    [SerializeField] private int score = 0;
    [SerializeField] private Text updatedScoreText;

    [Header("Target Settings")]
    [SerializeField] private GameObject[] targets;
    private int currentTargetIndex = 0;

    [Header("Timer Settings")]
    [SerializeField] private float timer;
    [SerializeField] private Text timerText;

    [Header("UI Elements")]
    [SerializeField] private GameObject GameUI;
    [SerializeField] private GameObject crosshairUI;
    [SerializeField] private GameObject LevelFailedUI;
    [SerializeField] private GameObject LevelPassedUI;

    private void Start()
    {
        InitializeGame();
    }

    private void Update()
    {
        UpdateTimer();
        UpdateScoreUI();
        CheckGameOver();
    }

    private void InitializeGame()
    {
        score = 0;
        SetUIState(GameUI, true);
        SetUIState(crosshairUI, true);
        SetUIState(LevelFailedUI, false);
        SetUIState(LevelPassedUI, false);

        Time.timeScale = 1f;
        DisableAllTargets();

        if (targets.Length > 0)
        {
            targets[currentTargetIndex].SetActive(true);
        }
    }

    private void UpdateTimer()
    {
        timer -= Time.deltaTime;
        timerText.text = "Time Left: " + Mathf.RoundToInt(timer);
    }

    private void UpdateScoreUI()
    {
        updatedScoreText.text = score + " / 10";
    }

    private void CheckGameOver()
    {
        if (timer <= 0 && score < 10)
        {
            EndGame(false);
        }

        if (score == 10)
        {
            EndGame(true);
        }
    }

    private void EndGame(bool isSuccess)
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        SetUIState(GameUI, false);
        SetUIState(crosshairUI, false);

        if (isSuccess)
        {
            SetUIState(LevelFailedUI, false);
            SetUIState(LevelPassedUI, true);
        }
        else
        {
            SetUIState(LevelFailedUI, true);
            SetUIState(LevelPassedUI, false);
            Time.timeScale = 0f;
        }
    }

    public void IncrementScore()
    {
        score++;
        if (targets.Length > 0)
        {
            targets[currentTargetIndex].SetActive(false);
        }

        currentTargetIndex++;
        if (currentTargetIndex < targets.Length)
        {
            targets[currentTargetIndex].SetActive(true);
        }
    }

    public int GetTargets()
    {
        return score;
    }

    private void SetUIState(GameObject uiElement, bool state)
    {
        uiElement.SetActive(state);
    }

    private void DisableAllTargets()
    {
        foreach (GameObject target in targets)
        {
            target.SetActive(false);
        }
    }
}
