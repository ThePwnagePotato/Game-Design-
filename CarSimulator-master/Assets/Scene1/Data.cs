using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour {

	void Awake(){
		DontDestroyOnLoad (transform.gameObject);
	} 

	//The Sprites
	public Sprite Tire_Left;
	public Sprite Tire_Right;
	public Sprite Chassis;

	//Parameters about the car
	public int Inertia;
	public int Steering;
	public int Grip;

	public int Drag;
	public int Mass;
	public int Durability;

	public int Acceleration;
	public int Top_Speed;

	//Parameters to pass on
	public float MaxSteerAngle = 0.75f;
	public float AirResistance = 2.5f;
	public float RollingResistance = 8f;
	public float TotalTireGripFront = 2.5f;
	public float TotalTireGripRear = 2.5f;
	public float SteerSpeed = 2.5f;
	public float SpeedTurningStability = 10f;
	public float DurabilityMax = 2000f;
	public float accelMultiplier = 1.4f;
	public float speedLimit = 16f;
}