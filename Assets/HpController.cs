using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HpController : MonoBehaviour {

//	private Player player;

	public EnemyWarriorController enemy;

	public Image lifeGreenGage;
	public Image lifeRedGage;
	public float maxhp = 1.0f;
	public float hp = 1.0f;

	void Start () {
//		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
		this.initParameter();
	}

	void Update () {
//		if (Input.GetKeyDown(KeyCode.UpArrow)) {
////			lifeGreenGage.fillAmount = 0.8f;
//			iTween.ValueTo(this.gameObject, iTween.Hash(
//				"from", 1f,
//				"to", 0.5f,
//				"time", 1f,
//				"easetype", iTween.EaseType.linear,
//				"onupdate", "downLifeRedGage",
//				"onupdatetarget", this.gameObject
//			));
//		}
	}

	private void initParameter() {
		lifeGreenGage = GameObject.Find("LifeGreenGage").GetComponent<Image>();
		lifeGreenGage.fillAmount = 1;

		lifeRedGage = GameObject.Find("LifeRedGage").GetComponent<Image>();
		lifeRedGage.fillAmount = 1;
	}

	public void downLifeRedGage() {
			lifeGreenGage.fillAmount = hp;

	}

	public void Subtraction(float damage)
	{
		Debug.Log(string.Format("DAMAGE {0}", damage));
		hp = hp - damage;
		Debug.Log(hp);
		iTween.ValueTo(this.gameObject, iTween.Hash(
			"from", maxhp,
			"to", maxhp - damage,
			"time", 1.0f,
			"easetype", iTween.EaseType.linear,
			"onupdate", "downLifeRedGage",
			"onupdatetarget", this.gameObject
		));
	}
}
