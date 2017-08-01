using UnityEngine;
using System.Collections;

public class EnemyWarriorController : MonoBehaviour {

	private Rigidbody myRigidBody;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){

		//敵にヒットした場合
		if (other.gameObject.tag == "enemyTag") {
			//喰らい判定を追加する
			Debug.Log("敵に当たったよ！");
			GetComponent<Animator> ().SetTrigger ("hitTrigger");
		}

	}
}
