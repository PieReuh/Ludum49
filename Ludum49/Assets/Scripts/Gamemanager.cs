using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Gamemanager : MonoBehaviour
{
	public static Gamemanager instance;
	[HideInInspector] public Mb_Interactible selectionnedInteractible;

	public void Awake ()
	{
		if (instance == null)
		{
			instance = this;
		}
		else if (instance != this)
		{
			Destroy(this);
		}
	}
}
