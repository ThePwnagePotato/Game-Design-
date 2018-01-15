using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next_Level : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, 100)) {
			if (string.Compare (hit.collider.name, "name") == 0) {
				SceneManager.LoadScene ("race");
			}
		}
	}
}
