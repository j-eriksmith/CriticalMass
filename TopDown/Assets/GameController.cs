using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    bool end = false;

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
	}

    public void GameOver(string player)
    {
        end = true;
    }

    void ReloadCurrentScene()
    {
        string sceneName = SceneManager.GetActiveScene().name;

        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
}
