using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApplyButton : MonoBehaviour {
	public PatchInventory playerPatchInv;
	public PatchCurrent playerPatchCur;
	public PatchButtonsManager playerPatchButtons;
	public GameObject playerCamera;
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

	public void OnApplyClick() {
		playerPatchButtons.patchButtons[playerPatchCur.patchCurrent].GetComponent<PatchButtonScript>().DoubleClick();
	}
}
