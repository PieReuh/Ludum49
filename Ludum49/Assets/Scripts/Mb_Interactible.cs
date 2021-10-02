using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mb_Interactible : MonoBehaviour, Popup
{
	public GameObject linkedUI;

	public void DeployUi ()
	{
	}

	public void ShowPopup ()
	{
		linkedUI.SetActive(true);
	}

	public void HidePopup ()
	{
		linkedUI.SetActive(false);
	}
}

public interface Popup
{
	void ShowPopup ();
	void HidePopup ();
}
