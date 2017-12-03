using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	public	float			toxicity = 50f;
	public	Slider			toxiSlider;

	// private static System.Random rnd = new System.Random();
	private	Rigidbody	rb;

	void Start () {
		InvokeRepeating("ToxicityUpdate", 2f, 0.2f);
	}
	
	void ToxicityUpdate() {
		toxicity -= 0.5f;
		if (toxicity < 0) {
			toxicity = 0;
		}
		toxiSlider.GetComponent<Slider>().value = toxicity;
    }

	void addToxicity(float i) {
		toxicity += i;
		if (toxicity > 100f) {
			toxicity = 100f;
		}
	}

	void OnCollisionEnter(Collision other)
	{
		Debug.Log(other.gameObject.tag);
		if (other.gameObject.tag == "cafe") {
			addToxicity(10f);
			GameObject.Destroy(other.gameObject);
		}
	}

	/*static void randomize (List<string> list) {
		int n = list.Count;
        while (n > 1) {
            int k = (rnd.Next(0, n) % n);
            n--;
            string value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
		int i = 0;
		while (i < list.Count) {
			Debug.Log(i + ": " + list[i]);
			i++;
		}
	}*/
}
