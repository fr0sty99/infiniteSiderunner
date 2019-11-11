using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    private int score;
    private int highScore;
    public Text scoreText;
    public Text highscoreText;
    public GameObject player;

    // Use this for initialization
    void Start () {
        highScore = PlayerPrefs.GetInt("High Score");
        highscoreText.text = "High Score: " + highScore;
        score = 0;
        scoreText.text = "Score: " + score;
    }

    private void Update()
    {
        score = ((int)player.transform.position.x + 16);
        scoreText.text = "Score: " + score;
    }

    // TODO: find out where to put this
    public void die()
    {
        // dying 
        // TODO: play audio and animation
        if(score > highScore)
        {
            highScore = score;
            score = 0;
        }
        highscoreText.text = ("High Score: " + highScore);

        //  scoreText.text = "High Score: " + highScore;
        PlayerPrefs.SetInt("High Score", highScore);
        SceneManager.LoadScene("MainScene");
    }

}
