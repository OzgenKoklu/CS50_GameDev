using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public bool isPlayer1Goal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (isPlayer1Goal)
            {
                GameObject.Find("ScoreManager").GetComponent<ScoreManager>().PlayerCPUScored();

            }
            else
            {
                GameObject.Find("ScoreManager").GetComponent<ScoreManager>().Player1Scored();
            }

        }



    }
}
