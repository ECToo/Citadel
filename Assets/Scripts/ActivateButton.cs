using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateButton : MonoBehaviour {
	public GeneralInventory playerGenInv;
	public GeneralInvCurrent playerGenCur;
	public GameObject playerCamera;
	public GeneralInventoryButtonsManager playerGenInvButtons;
	public Image ico;
	public Text ict;

	public void PtrEnter () {
		GUIState.a.isBlocking = true;
		playerCamera.GetComponent<MouseLookScript>().overButton = true;
		playerCamera.GetComponent<MouseLookScript>().overButtonType = 77;
		playerCamera.GetComponent<MouseLookScript>().currentButton = gameObject;
	}

	public void PtrExit () {
		GUIState.a.isBlocking = false;
		playerCamera.GetComponent<MouseLookScript>().overButton = false;
		playerCamera.GetComponent<MouseLookScript>().overButtonType = -1;
	}

	public void OnActivateClick() {
		playerGenInvButtons.genButtons[playerGenCur.generalInvCurrent].GetComponent<GeneralInvButtonScript>().DoubleClick();
		playerGenInv.generalInventoryIndexRef[playerGenCur.generalInvCurrent] = -1;
	}
}
