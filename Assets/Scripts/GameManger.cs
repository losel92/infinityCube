using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour {

    bool gameHasEnded = false;

    public float restartDelay = 2;

	public void EndGame()
    {
        if (gameHasEnded == false) {
            gameHasEnded = true;
            Debug.Log("game over");

            Invoke("RestartLvl", restartDelay);
        
        }
    }

    public void RestartLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



}
