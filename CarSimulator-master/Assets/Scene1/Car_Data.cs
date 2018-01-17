using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Data : MonoBehaviour {

	public GameObject Persistant_Object;
	Data Data;

	public Sprite Tire_Left;
	public Sprite Tire_Right;
	public Sprite Chassis;

	public string TireName = "default tire";
	public string ChassisName = "default chassis";

	public bool Looking;
	public int TempData1;
	public int TempData2;
	public int TempData3;

	public int Inertia;
	public int Steering;
	public int Grip;

	public int Drag;
	public int Mass;
	public int Durability;

	public int Acceleration;
	public int Top_Speed;

	void Start(){
		Persistant_Object = GameObject.Find ("Persistant_Object");
		Data = Persistant_Object.GetComponent<Data> ();
	}

	void Update(){
		Data.Tire_Left = Tire_Left;
		Data.Tire_Right = Tire_Right;
		Data.Chassis = Chassis;

		Data.Inertia = Inertia;
		Data.Steering = Steering;
		Data.Grip = Grip;

		Data.Drag = Drag;
		Data.Mass = Mass;
		Data.Durability = Durability;

		Data.Acceleration = Acceleration;
		Data.Top_Speed = Top_Speed;
	}
}
