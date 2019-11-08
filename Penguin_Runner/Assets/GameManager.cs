using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    private int highScore;
    public Text scoreText;
    public GameObject player;

    // Use this for initialization
    void Start () {
        highScore = PlayerPrefs.GetInt("High Score");
        scoreText.text = "High Score: " + highScore;
    }

    // TODO: find out where to put this
    public void die()
    {
        // dying 
        // TODO: play audio and animation
        // TODO: live score
        if (((int) player.transform.position.x) > highScore)
        {
            highScore = (int) player.transform.position.x;
        }
        scoreText.text = "High Score: " + highScore;
        PlayerPrefs.SetInt("High Score", highScore);
        SceneManager.LoadScene("MainScene");
    }

}
