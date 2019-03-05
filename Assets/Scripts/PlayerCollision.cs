using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour {

    public playerMovement pMovement;

    public int spawnDelay = 2;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            pMovement.enabled = false;


            FindObjectOfType<GameManger>().EndGame();
        }
    }




}
