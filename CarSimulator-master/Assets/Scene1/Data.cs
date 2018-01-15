using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour {

	void Awake(){
		DontDestroyOnLoad (transform.gameObject);
	} 

	public Sprite Tire_Left;
	public Sprite Tire_Right;
	public Sprite Chassis;

	public string TireName = "default tire";
	public string ChassisName = "default chassis";

	public float MaxSteerAngle = 0.75f;
	public float AirResistance = 2.5f;
	public float RollingResistance = 8f;
	public float TotalTireGripFront = 2.5f;
	public float TotalTireGripRear = 2.5f;
	public float SteerSpeed = 2.5f;
	public float SpeedTurningStability = 10f;
	public float Durability = 2000f;
	public float accelMultiplier = 1.4f;
	public float speedLimit = 16f;
}
