using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car_Controller : MonoBehaviour {
	Item Item;
	Car_Data Car_Data;
	Car_Menu Car_Menu;
	Sprite newSprite;
	string newName;

	// Use this for initialization
	void Start () {
		Car_Data = this.GetComponent<Car_Data> ();
		Car_Menu = this.GetComponent<Car_Menu> ();
	}
	
	// Update is called once per frame
	void Update() {
		if (Input.GetKey("escape")) {
			Application.Quit();
		}

		if (Input.GetMouseButtonDown(0)) {
			//Debug.Log("Pressed left click, casting ray.");
			CastRay();
		}
		CastHoverRay ();
	}

	void CastRay() {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit, 100)) {
			//check which object was hit
			//Debug.Log (hit.collider.name);
			Item = hit.collider.GetComponent<Item> ();
			if (Item != null) {
				newSprite = hit.collider.GetComponent<SpriteRenderer> ().sprite;
				newName = Item.name;

				if (Item.NextLevel == true) {
					SceneManager.LoadScene ("LevelSelect");
				}
				else if (Item.menu == false) {
					switch (Item.type) {
					case 0:
						Car_Data.Tire_Left = newSprite;
						Car_Data.Tire_Right = newSprite;
						Car_Data.TireName = newName;
						Car_Data.Inertia = Car_Data.TempData1;
						Car_Data.Steering = Car_Data.TempData2;
						Car_Data.Grip = Car_Data.TempData3;
						break;
					case 1:
						Car_Data.Chassis = newSprite;
						Car_Data.ChassisName = newName;
						Car_Data.Drag = Car_Data.TempData1;
						Car_Data.Mass = Car_Data.TempData2;
						Car_Data.Durability = Car_Data.TempData3;
						break;
					case 2:
						Car_Data.Acceleration = Car_Data.TempData1;
						Car_Data.Top_Speed = Car_Data.TempData2;
						break;
					}
				}else {
					switch (Item.type) {
					case 0:
						Car_Menu.menu = 1;
						break;
					case 1:
						Car_Menu.menu = 2;
						break;
					case 2:
						Car_Menu.menu = 3;
						break;
					case 3:
						Car_Menu.menu = 0;
						Car_Menu.scroll = 0;
						break;
					case 4:
						Car_Menu.scroll = Car_Menu.scroll + 1;
						break;
					case 5:
						Car_Menu.scroll = Car_Menu.scroll - 1;
						break;
					}
					Car_Menu.update = true;
					}
				}
			}
		}

	void CastHoverRay() {
		Car_Data.Looking = false;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit, 100)) {
			//check which object was hit
			//Debug.Log (hit.collider.name);
			Item = hit.collider.GetComponent<Item> ();
			if (Item != null) {
				if (Item.menu == false) {
					Car_Data.Looking = true;
					Car_Data.TempData1 = Item.data1;
					Car_Data.TempData2 = Item.data2;
					Car_Data.TempData3 = Item.data3;
						
				}
			}
		}
	}
}



