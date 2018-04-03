using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	//キューブの移動速度
	private float speed = -0.2f;

	//消滅位置
	private float deadLine = -10;


	void Start () {
		
	}


	void Update () {
		//キューブを移動させる
		transform.Translate(this.speed,0,0);


		//画面外に出たら破棄する
		if (transform.position.x < this.deadLine) {
			Destroy (gameObject);
		}
	}


	//キューブ衝突時の効果音
	void OnCollisionEnter2D(Collision2D other){
		//キューブが、キューブか地面に衝突した場合は効果音再生
		if (other.gameObject.tag == "GroundTag"|| other.gameObject.tag == "CubeTag") {
			//このオブジェクトのオーディオコンポーネントを取得
			AudioSource BlockAudio = GetComponent<AudioSource> ();
			//効果音再生
			BlockAudio.Play ();
		}
	}

}