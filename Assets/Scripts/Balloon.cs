using UnityEngine;
using System.Collections;

public class Balloon : MonoBehaviour {

	public float floatSpeed;
	public GameManager gameManager;
	public float life = 12f;
	public GameObject pop;
	// Use this for initialization
	void Start () {
		Invoke("Die",life);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(transform.up*floatSpeed*Time.deltaTime);
	}

	void OnParticleCollision(){
		GameObject p = GameObject.Instantiate(pop,transform.position,Quaternion.identity) as GameObject;
		gameManager.AddScore();
		Destroy(gameObject);
	}

	void Die (){
		Destroy(gameObject);
	}


}
