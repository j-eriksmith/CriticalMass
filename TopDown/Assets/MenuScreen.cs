using UnityEngine;
using System.Collections;

public class MenuScreen : MonoBehaviour {

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Application.LoadLevel("UIStart");
        }
    }
	public void ChangeScene(string sceneName){
		Application.LoadLevel(sceneName);
	}
}
