using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 


public class UIController : MonoBehaviour {


	//ゲームオーバーテキスト
	private GameObject gameOverText;
	//走行距離テキスト
	private GameObject runLengthText;
	//走った距離
	private float len = 0;
	//走る速度
	private float speed = 0.03f;
	//ゲームオーバーの判定
	private bool isGameOver = false;


	void Start () {
		//シーンビューからオブジェクトの実体を検索
		this.gameOverText = GameObject.Find("GameOver");
		this.runLengthText = GameObject.Find ("RunLength");
	}
	


	void Update () {
		if (this.isGameOver == false) {
			//走った距離を更新する
			this.len += this.speed;
			//走った距離を表示する
			this.runLengthText.GetComponent<Text> ().text = "Distance: " + len.ToString ("F2") + "m";
		}

		//ゲームオーバーになった時
		if(this.isGameOver == true){
			if (Input.GetMouseButtonDown (0)) {
			//クリックされたらシーンをロードする
				SceneManager.LoadScene ("GameScene");
			}
		}
	}

	public void GameOver(){
		this.gameOverText.GetComponent<Text>().text = "GAMEOVER";
		this.isGameOver = true;

	}
}
