using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripttestfatigue : MonoBehaviour {
	public Animator anim;

	// Use this for initialization
	void Start () {
		
		// anim = GetComponent<Animator>();
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("r") == true)
			anim.SetFloat("excitement", anim.GetFloat("excitement") - 1);
		else if ((Input.GetKey("t") == true))
			anim.SetFloat("excitement", anim.GetFloat("excitement") + 1);
	}
}
