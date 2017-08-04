using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour {

	const float interval = 1.5f; // 指定秒
	float timer;
	bool gototitle = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//
		if (gototitle == true) {
			timer += Time.deltaTime;
			if (timer >= interval) {
				SceneManager.LoadScene ("GameScene");
			}
		}

		 //クリックされたらシーンをロードする（追加）
		if (Input.GetMouseButtonDown (0)){
			//決定音を鳴らす（追加）
			GetComponent<AudioSource> ().Play();
			gototitle = true;
			Debug.Log (gototitle);
			//GameSceneを読み込む（追加）
//			SceneManager.LoadScene ("GameScene");
		}
	
	}
		
}
