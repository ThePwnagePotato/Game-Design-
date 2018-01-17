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
	public int MassOld;
	public int Durability;

	public int Acceleration;
	public int Top_Speed;

	//------------------------------------------------------------------------------------------------------//
	//Tires
	public float MaxSteerAngle; //0.3-1
	public float SpeedTurningStability;//5-15
	public float SteerSpeed;//1-4
	public float TotalTireGrip;//1-4
	public float RollingResistance;//5-25

	//Chassis
	public float DurabilityMax;//100-1000
	public float AirResistance;//0-15
	public float Mass;//800-4500

	//Engine
	public float accelMultiplier;//0.5-1.6
	public float speedLimit;//5-30
	//------------------------------------------------------------------------------------------------------//

	void Update (){
		MaxSteerAngle = 0.3f + 0.07f * Steering;
		SpeedTurningStability = 5 + 1f * Steering;
		SteerSpeed = 1 + 0.3f * Steering;
		TotalTireGrip = 1 + 0.3f * Grip;
		RollingResistance = 5f + 2f * Inertia;

		DurabilityMax = 100f + 90f * Durability;
		AirResistance = 1.5f * Drag;
		Mass = 800f + 370f * MassOld;

		accelMultiplier = 0.5f + 0.11f * Acceleration;
		speedLimit = 5 + 2.5f * Top_Speed;
		}
}