using UnityEngine;
using System.Collections;

public class Pop : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<AudioSource>().Play();
		StartCoroutine("PopBalloon",0f);
	}
	
	IEnumerator PopBalloon(){
		while (GetComponent<AudioSource>().isPlaying){
			yield return null;
		}
		Destroy(gameObject);
	}
}
