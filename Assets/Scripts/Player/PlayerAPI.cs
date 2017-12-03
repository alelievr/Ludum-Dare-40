using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Invector.CharacterController;

public class PlayerAPI : MonoBehaviour
{
	vThirdPersonController	controller;
	vThirdPersonInput		input;

	public float		defaultPlayerJumpPower = 4;
	public float		defaultPlayerWalkSpeed = 2.5f;
	public float		defaultPlayerRunSpeed = 3;
	public float		defaultPlayerSprintSpeed = 4;

	new public Rigidbody	rigidbody { get; private set; }
	public bool				isGrounded { get { return controller.isGrounded; } }
	public float			excitation { get { return controller.excitation; } }

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

	public void AddMovement(Vector2 add)
	{
		controller.input.x += add.x;
		controller.input.y += add.y;
	}

	public void SetRunSpeed(float speed) { controller.freeSprintSpeed = speed; }
	public void SetWalkSpeed(float speed) { controller.freeRunningSpeed = speed; }
	public void AddExcitation(float excitation) { controller.excitation += excitation; }
}
