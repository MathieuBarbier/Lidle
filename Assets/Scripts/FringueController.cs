using UnityEngine;
using System.Collections;

public class FringueController : MonoBehaviour {

	public int life;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void decreaseLife() {
		life -= FingerManager.instance.fingerPower;

		checkStatus();
	}

	public void checkStatus() {
		if(life <= 0) {
			destroyFringue();
		}
	}

	public void destroyFringue() {

	}
}
