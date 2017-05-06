using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject player;
    public int lives = 3;
    public GameObject gameOver;
    public GameObject youWon;
    public int score = 0;
    public Text scoreText;
    public Text time;
    private GameObject clonePlayer;

    float resetDelay = 1f;
    float timeLeft = 60.0f;

    public static GameManager instance { get; set; }

    private void Awake () {
        instance = this;

        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);


        Setup();

    }
    
    void Setup()
    {
        //clonePlayer = Instantiate(player, transform.position, Quaternion.identity) as GameObject;
        //Instantiate(bricksPrefab, transform.position, Quaternion.identity);
    }

    public void CheckGameOver()
    {
        if (lives < 1)
        {
            gameOver.SetActive(true);
            Time.timeScale = .25f;
            Invoke("Reset", resetDelay);

            SceneManager.LoadScene("menu");
        }
    }
    public void LoseLife()
    {
        lives--;
        
        CheckGameOver();
    }

    void Update () {

        timeLeft -= Time.deltaTime;

    }
}
