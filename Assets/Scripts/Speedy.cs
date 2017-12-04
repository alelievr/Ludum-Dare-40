using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedy : MonoBehaviour {

	public	ToxiController	Player;
	PlayerAPI	api;
	private	float				speedW;
	private	float				speedR;

	// Use this for initialization
	void Start () {
		api = GetComponent< PlayerAPI >();
		speedW = api.defaultPlayerWalkSpeed;
		speedR = api.defaultPlayerRunSpeed;
	}

	void Update() {
		api.SetWalkSpeed(speedW + (Player.toxicity / 5));
		api.SetRunSpeed(speedR + (Player.toxicity / 5));
	}
}
