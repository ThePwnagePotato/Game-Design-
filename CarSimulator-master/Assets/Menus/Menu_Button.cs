using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Button : MonoBehaviour {

    public void Update()
    {
        float x = 0 ;
        float y = 0 ; 

        if (Input.GetMouseButtonDown(0))
        {
            x = Input.mousePosition.x;
            y = Input.mousePosition.y;
			RaycastHit2D hit = Physics2D.Raycast(new Vector2(x, y), Vector2.zero);
			if (hit != null) {
				if (hit.collider != null) {
					//Debug.Log (hit.collider.name);
					if (hit.collider.name.Equals("Start")) {
						SceneManager.LoadScene("Scene1");
					} else if (hit.collider.name.Equals("Quit")) {
						Application.Quit ();
					}
				}
			}
        }

		if (Input.GetKey("escape")) {
			Application.Quit();
		}
    } 

}

