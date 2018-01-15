using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Renderer : MonoBehaviour {
	GameObject Tire_Left;
	GameObject Tire_Right;
	GameObject Chassis;
	Car_Data Car_Data;

	Vector3 normal;
	Vector3 tank;

	void Start () {
		tank = new Vector3 (-2,(float)1.65,0);
		normal = new Vector3 ((float)-5.5, (float)1.5, 0);

		Tire_Left = this.gameObject.transform.GetChild (0).gameObject;
		Tire_Right = this.gameObject.transform.GetChild (1).gameObject;
		Chassis = this.gameObject.transform.GetChild (2).gameObject;
		Car_Data = this.GetComponent<Car_Data> ();
	}

	// Update is called once per frame
	void Update () {
		if (string.Compare (Car_Data.TireName, "Tank Treads") == 0) {
			Tire_Left.transform.position = tank;
			Tire_Left.GetComponent<SpriteRenderer> ().sprite = Car_Data.Tire_Left;
			Tire_Right.GetComponent<SpriteRenderer> ().sprite = null;
		} else {
			Tire_Left.transform.position = normal;
			Tire_Left.GetComponent<SpriteRenderer> ().sprite = Car_Data.Tire_Left;
			Tire_Right.GetComponent<SpriteRenderer> ().sprite = Car_Data.Tire_Right;
			Chassis.GetComponent<SpriteRenderer> ().sprite = Car_Data.Chassis;
		}
	}
}
