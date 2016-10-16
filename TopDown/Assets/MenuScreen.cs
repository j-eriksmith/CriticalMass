using UnityEngine;
using System.Collections;

public class MenuScreen : MonoBehaviour {

	public void ChangeScene(string sceneName){
		Application.LoadLevel(sceneName);

	}
}
