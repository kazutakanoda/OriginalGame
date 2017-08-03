using UnityEngine;
using System.Collections;

public class WarriorController : MonoBehaviour {


	private Rigidbody myRigidBody;

	public int hp = 100;
	public int maxhp = 100;


	private float turnForce = 600.0f;

	// Use this for initialization
	void Start () {

		this.myRigidBody = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void Update () {

		// マウスがクリックされた場合
		if (Input.GetMouseButtonDown (0)) {
			// Animatorコンポーネントを取得し、"attackTrigger"をtrueにする
			GetComponent<Animator> ().SetTrigger ("attackTrigger");

		} else if (Input.GetKey (KeyCode.DownArrow)) {
			
			// Animatorコンポーネントを取得し、"defenceTrigger"をtrueにする
			GetComponent<Animator> ().SetTrigger ("defenceTrigger");
			//左右が選択された場合
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			
			// Animatorコンポーネントを取得し、"walkBool"をtrueにする
			GetComponent<Animator> ().SetBool ("walkBool", true);
			//左の場合後退させる
			this.myRigidBody.AddForce (-this.turnForce, 0, 0);
//			Debug.Log ("左");
		} else if (Input.GetKey (KeyCode.RightArrow)) {

			// Animatorコンポーネントを取得し、"walkBool"をtrueにする
			GetComponent<Animator> ().SetBool ("walkBool", true);
			//右の場合前進させる
			this.myRigidBody.AddForce (this.turnForce, 0, 0);
//				Debug.Log ("右");
		} else if (Input.GetKeyUp (KeyCode.RightArrow) || Input.GetKeyUp (KeyCode.LeftArrow)) {
			// Animatorコンポーネントを取得し、"walkBool"をfalseにする
			GetComponent<Animator> ().SetBool ("walkBool", false);

//		if (Input.GetKey (KeyCode.RightArrow)) {
//			// Animatorコンポーネントを取得し、"walkBool"をfalseにする
//			GetComponent<Animator> ().SetBool ("walkBool",true);
//			//前進させる
//			this.myRigidBody.AddForce (this.turnForce, 0, 0);
//
//			Debug.Log ("右");
//		}else{
//			// Animatorコンポーネントを取得し、"attackTrigger"をtrueにする
//			GetComponent<Animator> ().SetBool ("walkBool",false);
//		}


		}
	}

//	void OnTriggerEnter(Collider other){
//
//		//敵にヒットした場合
//		if (other.gameObject.tag == "enemyTag") {
//			//喰らい判定を追加する
//			Debug.Log("敵に当たったよ！");
//			GetComponent<Animator> ().SetTrigger ("hitTrigger");
//		}
//
//	}
}