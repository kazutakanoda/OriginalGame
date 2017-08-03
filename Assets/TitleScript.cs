using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// クリックされたらシーンをロードする（追加）
		if (Input.GetMouseButtonDown (0)){
			//GameSceneを読み込む（追加）
			SceneManager.LoadScene ("GameScene");
		}
	
	}
}
