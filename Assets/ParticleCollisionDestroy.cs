using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollisionDestroy : MonoBehaviour {

	void OnParticleCollision(GameObject other)
	{
		Destroy(other);
	}

}
