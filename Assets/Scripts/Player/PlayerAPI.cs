﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Invector.CharacterController;

public class PlayerAPI : MonoBehaviour
{
	vThirdPersonController	controller;
	vThirdPersonInput		input;

	public static float		defaultPlayerJumpPower = 4;
	public static float		defaultPlayerWalkSpeed = 2.5f;
	public static float		defaultPlayerRunSpeed = 3;
	public static float		defaultPlayerSprintSpeed = 4;

	new public Rigidbody	rigidbody {get; private set; }
	public bool				isGrounded { get { return controller.isGrounded; } }

	void Awake ()
	{
		controller = FindObjectOfType< vThirdPersonController >();
		input = FindObjectOfType< vThirdPersonInput >();
		rigidbody = controller.GetComponent< Rigidbody >();
	}

	public void Jump(float jumpPower)
	{
		controller.jumpHeight = jumpPower;
		controller.Jump();
	}

	public void SetRunSpeed(float speed) => controller.freeRunningSpeed = speed;
	public void SetWalkSpeed(float speed) => controller.freeWalkSpeed = speed;
	public void SetSprintSpeed(float speed) => controller.freeSprintSpeed = speed;
	
}
