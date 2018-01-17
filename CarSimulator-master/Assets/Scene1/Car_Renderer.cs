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
		tank = new Vector3 (-2,(float)1.15,0);
		normal = new Vector3 ((float)-5.5, (float)1.0, 0);

		Tire_Left = this.gameObject.transform.GetChild (0).gameObject;
		Tire_Right = this.gameObject.transform.GetChild (1).gameObject;
		Chassis = this.gameObject.transform.GetChild (2).gameObject;
		Car_Data = this.GetComponent<Car_Data> ();
	}

	// Update is called once per frame
	void Update () {
		Tire_Right.transform.position = new Vector3((float)1.24,1,0);

		if (string.Compare (Car_Data.TireName, "Tank Treads") == 0) {
			Tire_Left.transform.position = tank;
			Tire_Left.GetComponent<SpriteRenderer> ().sprite = Car_Data.Tire_Left;
			Tire_Right.GetComponent<SpriteRenderer> ().sprite = null;
		} else {
			Tire_Left.transform.position = normal;
			Tire_Left.GetComponent<SpriteRenderer> ().sprite = Car_Data.Tire_Left;
			Tire_Right.GetComponent<SpriteRenderer> ().sprite = Car_Data.Tire_Right;
		}
			
		Chassis.GetComponent<SpriteRenderer> ().sprite = Car_Data.Chassis;

		if(string.Compare(Car_Data.ChassisName,"Green") == 0){
			Chassis.transform.position = new Vector3((float)-2.32,(float)2.99,0);
		}
		if(string.Compare(Car_Data.ChassisName,"Blue") == 0){
				Chassis.transform.position = new Vector3((float)-2.44,(float)3.21,0);
		}
		if(string.Compare(Car_Data.ChassisName,"Red") == 0){
			Chassis.transform.position = new Vector3((float)-2.4,(float)2.2,0);
			Tire_Left.transform.position = new Vector3((float)-5.8,(float)0.7,0);
			Tire_Right.transform.position = new Vector3((float)0.6,(float)0.7,0);

			if (string.Compare (Car_Data.TireName, "Tank Treads") == 0) {
				Tire_Left.transform.position = new Vector3((float)-2.5,(float)0.6,0);
			}
		}
	}
}
