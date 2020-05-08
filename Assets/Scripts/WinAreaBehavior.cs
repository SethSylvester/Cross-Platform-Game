using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//The behavior for the win area
public class WinAreaBehavior : MonoBehaviour
{
    PlayerBehavior playerb;
    [SerializeField]
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        playerb = player.GetComponent<PlayerBehavior>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == player)
        {
            GlobalVariable.won = true;
            SceneManager.LoadScene(2);
        }
    }
}
