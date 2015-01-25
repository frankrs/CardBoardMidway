using UnityEngine;
using System.Collections;

public class Pop : MonoBehaviour {

	// Use this for initialization
	void Start () {
		audio.Play();
		StartCoroutine("PopBalloon",0f);
	}
	
	IEnumerator PopBalloon(){
		while (audio.isPlaying){
			yield return null;
		}
		Destroy(gameObject);
	}
}
