using UnityEngine;
using System.Collections;

public class GirlPanel : MonoBehaviour {

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
