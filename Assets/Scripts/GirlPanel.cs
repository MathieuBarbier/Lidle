using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GirlPanel : MonoBehaviour {

	public List<FringueController> fringues = new List<FringueController>();
	public int currentFringueIndex;

	private Animator animator;

	void Awake() {
		animator = GetComponent<Animator>();
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void initFringues() {
		currentFringueIndex = 0;
		fringues.AddRange(transform.GetComponentsInChildren<FringueController>());
		for(int i = 1; i < fringues.Count; i++) {
			fringues[i].init();
		}
	}

	public void goLeft() {
		animator.SetTrigger("goLeft");
	}

	public void goRight() {
		animator.SetTrigger("goRight");
	}

	public void setRight() {
		animator.SetTrigger("setRight");
	}

	public void comeFromRight() {
		animator.SetTrigger("comeFromRight");
	}

	public void comeFromLeft() {
		animator.SetTrigger("comeFromLeft");
	}
}
