using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Behaviors for walls
public class WallBehavior : MonoBehaviour
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
            playerb.Fling();
        }
    }
}