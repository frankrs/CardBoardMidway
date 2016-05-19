using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public BalloonFactory balloonFactory;
	public ScoreKeeper scoreKeeper;


	void Start () {
		InvokeRepeating("ReleaseBalloon",balloonFactory.generationTime,balloonFactory.generationTime);
	}


	void Update(){
		if(Input.GetKeyDown("escape")){
			Application.Quit();
		}
	}



	void ReleaseBalloon(){
		GameObject b = GameObject.Instantiate(balloonFactory.balloonObject,new Vector3(Random.Range(balloonFactory.xLimit.min.position.x,balloonFactory.xLimit.max.position.x),balloonFactory.xLimit.min.position.y,Random.Range(balloonFactory.zLimit.min.position.z,balloonFactory.zLimit.max.position.z)),Quaternion.Euler(0f,0f,0f)) as GameObject;
		b.GetComponent<Balloon>().gameManager = this;
		b.GetComponent<Renderer>().material.color = balloonFactory.balloonColors[Random.Range(0,balloonFactory.balloonColors.Length-1)];
	}

	public void AddScore(){
		scoreKeeper.score ++;
		scoreKeeper.scoreBoard.text = "Score:"+scoreKeeper.score.ToString();
	}

}


[System.Serializable]
public class BalloonFactory{
	public GameObject balloonObject;
	public float generationTime;
	public Limit xLimit;
	public Limit zLimit;
	public Color[] balloonColors;
}

[System.Serializable]
public class ScoreKeeper{
	public int score;
	public TextMesh scoreBoard;
}


[System.Serializable]
public class Limit{
	public Transform min;
	public Transform max;
}

