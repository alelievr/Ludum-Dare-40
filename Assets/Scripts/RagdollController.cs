using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollController : MonoBehaviour
{
	Collider[]			ragdollColliders;
	Rigidbody[]			ragdollRigidbodies;
	CharacterJoint[]	ragdollJoints;

	// Use this for initialization
	void Start ()
	{
		ragdollColliders = GetComponentsInChildren< Collider >();
		ragdollRigidbodies = GetComponentsInChildren< Rigidbody >();
		ragdollJoints = GetComponentsInChildren< CharacterJoint >();
	}

	public void ActivateRagdoll()
	{

	}
}
