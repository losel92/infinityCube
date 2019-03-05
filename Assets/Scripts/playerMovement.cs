using UnityEngine;

public class playerMovement : MonoBehaviour {

    public Rigidbody rb;
    public GameObject inGameMenu;

    public float forwardForce;
    public float sidewaysForce;
    public bool gameStarted = false;
    public bool gamePaused = false;
	
	// Update is called once per frame
	void FixedUpdate () {


        if (Input.GetKey("w") || Input.GetKey("up") || Input.GetKey("space") || Input.GetKey("return"))
        {
            gameStarted = true;
        }

        if (gameStarted)
        {
            rb.AddForce(0, 0, forwardForce * Time.fixedDeltaTime);

            if (Input.GetKey("d") || Input.GetKey("right"))
            {
                rb.AddForce(sidewaysForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.GetKey("a") || Input.GetKey("left"))
            {
                rb.AddForce(-sidewaysForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (Input.GetKey("r"))
            {
                FindObjectOfType<GameManger>().RestartLvl();
            }

            if (rb.position.y < -1f)
            {
                FindObjectOfType<GameManger>().EndGame();
            }
        }

        if ((Input.GetKey("p") || Input.GetKey(KeyCode.Escape)) && !gamePaused)
        {
            gamePaused = true;
            PauseGame();
        }

        Debug.Log(rb.velocity.z);
    }

    public void PauseGame()
    {
        Time.timeScale = 0.0f;
        inGameMenu.SetActive(true);
    }
}
