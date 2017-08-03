using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyWarriorController : MonoBehaviour {

	private Rigidbody myRigidBody;

	public int hp = 100;
	public int maxhp = 100;

	const float interval = 1.6f; // 指定秒
	float timer;
	bool invisible = false;

	//体力バーの情報を保存する
	private GameObject stateHp;

	// Use this for initialization
	void Start () {
		
		//シーン中のstateTextオブジェクトを取得（追加）
		this.stateHp = GameObject.Find("EnemyHp");
	}
	
	// Update is called once per frame
	void Update () {

		if (invisible == true) {
			timer += Time.deltaTime;
			Debug.Log (timer);
			if (timer >= interval) {
				invisible = false;
				timer = 0;
			}
		}

	}

	void OnTriggerEnter(Collider other){

		//敵にヒットした場合
		if (invisible == false) {
			//処理中はフラグをOnにする
			invisible = true;
			hp -= 30;
			if (other.gameObject.tag == "swordTag") {
				//喰らい判定を追加する
//			Debug.Log("敵に当たったよ！");
				if (hp > 0) {
					GetComponent<Animator> ().SetTrigger ("hitTrigger");
//			Debug.Log (hp);
//			Debug.Log (maxhp);
					stateHp.GetComponent<HpController> ().Subtraction (0.3f);
				} else if (hp <= 0) {
					this.
					stateHp.GetComponent<HpController> ().Subtraction (0.3f);
					GetComponent<Animator> ().SetBool ("deadBool", true);
				}
			}

		}else{
			//Falseなら値をそのまま返す
			return;
		}
	}
}
