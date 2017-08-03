using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TitleScript2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// クリックされたらシーンをロードする（追加）
		if (Input.GetKey(KeyCode.Z)){
			//GameSceneを読み込む（追加）
			SceneManager.LoadScene ("TitleScene");
		}
	}
}
