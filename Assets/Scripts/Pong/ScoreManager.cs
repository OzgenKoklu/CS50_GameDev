using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject Ball;

    [Header("Player 1")]
    public GameObject Player1Paddle;
    public GameObject Player1Goal;

    [Header("Player CPU")]
    public GameObject PlayerCPUPaddle;
    public GameObject PlayerCPUGoal;

    [Header("Score UI")]
    public GameObject Player1Text;

    public GameObject PlayerCPUText;

    private int Player1Score=0;
    private int PlayerCPUScore=0;
    private void Awake()
    {
        Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        PlayerCPUText.GetComponent<TextMeshProUGUI>().text = PlayerCPUScore.ToString();
    }
    public void Player1Scored()
    {
        Player1Score++;
        Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        StartCoroutine(ResetRoutine());
    }

    public void PlayerCPUScored()
    {
        PlayerCPUScore++;
        PlayerCPUText.GetComponent<TextMeshProUGUI>().text = PlayerCPUScore.ToString();
        StartCoroutine(ResetRoutine());
    }

    private void ResetPosition()
    {
        PlayerCPUPaddle.GetComponent<PlayerAi>().Reset();
        Player1Paddle.GetComponent<Player1Input>().Reset();
        Ball.GetComponent<BallBehaviour>().Reset();
    }

    IEnumerator ResetRoutine()
    {
        yield return new WaitForSeconds(1.5f);
        ResetPosition();
    }

}
