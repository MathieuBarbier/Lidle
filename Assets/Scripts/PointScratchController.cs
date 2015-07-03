using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class PointScratchController : MonoBehaviour, IPointerDownHandler, IPointerExitHandler, IDragHandler {

	public FringueController fringue;

	public bool isTouched;
	public float scratchRequired;

	public float currentScratch;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnDestroy() {
		endPoint();
	}

	public void validatePointAction() {
		fringue.decreaseLife();
	}

	public void OnPointerDown(PointerEventData eventData) {
		isTouched = true;
		currentScratch = 0;
	}

	public void OnPointerExit(PointerEventData eventData) {
		isTouched = false;
	}

	public void OnDrag(PointerEventData eventData) {
		if(isTouched) {
			currentScratch += eventData.delta.magnitude;
		}
	}

	public void endPoint() {
		if(currentScratch >= scratchRequired) {
			validatePointAction();
		}
	}
}
