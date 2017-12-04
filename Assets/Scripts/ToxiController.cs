using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ToxiController : MonoBehaviour {

	// Use this for initialization
	public	float			toxicity = 50f;
	public	float			fatigue = 50f;
	public	Slider			toxiSlider;
	public	Slider			fatigueSlider;
	public	Text			sleeptxt;
	public	bool			GameState;

	// private static System.Random rnd = new System.Random();
	private	RectTransform	sleepRT;
	private	Rigidbody		rb;

	void Start () {
		GameState = true;
		sleepRT = sleeptxt.GetComponent<RectTransform>();
		sleepRT.localPosition = new Vector3( 0, 450, 0);
		InvokeRepeating("ToxicityUpdate", 2f, 0.2f);
		InvokeRepeating("fatigueUpdate", 2f, 0.2f);
	}
	
	void FixedUpdate()
	{
		if (!GameState) {
			sleepRT.localPosition = Vector3.MoveTowards(sleepRT.localPosition, new Vector3(0, -450f, 0), 1f);
		}
	}

	void sleep() {
		Debug.Log("sleep");
		// sleepRT.DOMoveY(sleepRT.position.y - 1, 2f);
		sleepRT.position = new Vector3( 0, 450, 0);
		sleeptxt.enabled = true;
		sleepRT.position = Vector3.MoveTowards(sleepRT.position, new Vector3(0, -450f, 0), 10);
		while (sleepRT.position.y > 0) {
			sleepRT.position = new Vector3( 0, sleepRT.position.y - 0.5f, 0) * Time.deltaTime * 60f;
		}
		// sleeptxt.GetComponent<Text>();
	}

	// IEnumerator Dors() {
	// 	sleepRT.position = new Vector3( 0, 450, 0);
	// 	sleeptxt.enabled = true;
	// 	while (sleepRT.position.y > 0) {
	// 		sleepRT.position = new Vector3( 0, sleepRT.position.y - 0.5f, 0) * Time.deltaTime * 60f;
	// 	}

	// 	yield return new WaitForSeconds(2);
	// }

	void ToxicityUpdate() {
		if (GameState) {
			toxicity -= 0.5f;
			if (toxicity < 0) {
				toxicity = 0;
			}
			toxiSlider.GetComponent<Slider>().value = toxicity;
		}
    }
	
	void fatigueUpdate() {
		if (GameState) {
			fatigue += 0.5f;
			if (fatigue >= 100) {
				// sleep();
				GameState = false;
			}
			fatigueSlider.GetComponent<Slider>().value = fatigue;
		}
    }

	void addFatigue(float i) {
		fatigue += i;
		if (fatigue > 100f) {
			fatigue = 100f;
		}
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
			addFatigue(-10f);
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
