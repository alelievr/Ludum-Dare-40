using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ScalingPlatform : MonoBehaviour
{
	public float	duration = 2;
	public Ease		ease;
	public Vector3	scale;

	void Start ()
	{
		transform.DOScale(Vector3.one / 2, duration).SetLoops(-1).SetEase(ease);
	}
	void Update () {
		
	}
}
