using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverBehavior : MonoBehaviour
{
    [SerializeField]
    Text text;

    // Update is called once per frame
    void Update()
    {
        //Display text dependent on if you win or lose.
        if (GlobalVariable.won)
            text.text = "You Win!";
        else
            text.text = "You Lose :(";
    }

    public void RestartGame()
    {
        //Reset the won to false
        GlobalVariable.won = false;
        //Restart the game
        SceneManager.LoadScene(0);
    }
}
