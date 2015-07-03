using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class PointSlideController : MonoBehaviour, IPointerDownHandler, IPointerExitHandler {

	public FringueController fringue;

	public bool isTouched;

	public float maxTimeCount;
	public float timeTouchedRequired;
	public float currentTimeTouched;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(isTouched) {
			currentTimeTouched += Time.deltaTime;
		}

		maxTimeCount += Time.deltaTime;
	}

	void OnDestroy() {
		endPoint();
	}

	public void validatePointAction() {
		fringue.decreaseLife();
	}

	public void OnPointerDown(PointerEventData eventData) {
		isTouched = true;
	}

	public void OnPointerExit(PointerEventData eventData) {
		isTouched = false;
	}

	public void endPoint() {
		if(currentTimeTouched >= timeTouchedRequired) {
			validatePointAction();
		}
	}
}
