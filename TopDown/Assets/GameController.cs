using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    bool end = false;

    public GameObject winText;
    public GameObject optionsText;

    float time1;
    float time2;

    string player;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
	    if (end == true)
        {

            if (Input.GetKeyDown(KeyCode.R))
            {
                ReloadCurrentScene();
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                SceneManager.LoadScene("UIStart", LoadSceneMode.Single);
            }
        }

        time2 = Time.time - time1;

        Debug.Log(time2.ToString());
        Debug.Log(end);
        if (end && time2 >= 2)
        {


            winText.SetActive(true);
            optionsText.SetActive(true);
            if (player == "1")
                winText.GetComponent<Text>().text = "Player 2 Wins!";
            if (player == "2")
                winText.GetComponent<Text>().text = "Player 1 Wins!";

        }
    }

    public void GameOver(string temp)
    {
        if (!end)
        {
            end = true;

            player = temp;

            time1 = Time.time;
        }
    }

    void ReloadCurrentScene()
    {
        string sceneName = SceneManager.GetActiveScene().name;

        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    void winDelay()
    {
        return;
    }
}
