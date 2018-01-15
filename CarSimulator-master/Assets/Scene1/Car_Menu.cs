﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Menu : MonoBehaviour {
	Car_Data Car_Data;

	public int menu;
	public int scroll;
	public bool update = true;

	public GameObject ArrowLeft;
	public GameObject ArrowRight;
	public GameObject ArrowBack;

	public GameObject Tire_Menu;
	public GameObject Chassis_Menu;
	public GameObject Engine_Menu;

	public GameObject Tire0;
	public GameObject Tire1;
	public GameObject Tire2;
	public GameObject Tire3;
	public GameObject Tire4;
	public GameObject Tire5;

	public GameObject DataBar1;
	public GameObject DataBar2;
	public GameObject DataBar3;

	Vector3 Storage;
	Vector3 Pos1;
	Vector3 Pos3;
	Vector3 Pos2;
	Vector3 Back;
	Vector3 Left;
	Vector3 Right;

	Vector3 BarPos1;
	Vector3 BarPos3;
	Vector3 BarPos2;

	void Start () {
		Car_Data = this.GetComponent<Car_Data> ();

		Storage = new Vector3 (0, -10, 0);
		Pos1 = new Vector3 (-6, -3, 0);
		Pos2 = new Vector3 ((float)-2.5, -3, 0);
		Pos3 = new Vector3 (1, -3, 0);
		Back = new Vector3 ((float)-8.1,(float)-1.75,0);
		Left = new Vector3 ((float)-8.2,-3,0);
		Right = new Vector3 ((float)3.2,-3,0);

		BarPos1 = new Vector3 ((float)6.5,-2,0);
		BarPos2 = new Vector3 ((float)6.5,(float)-3.1,0);
		BarPos3 = new Vector3 ((float)6.5,(float)-4.2,0 );

		ArrowLeft = GameObject.Find ("ArrowLeft");
		ArrowRight = GameObject.Find ("ArrowRight");
		ArrowBack = GameObject.Find ("ArrowBack");

		Tire_Menu = GameObject.Find ("Tire_Menu");
		Chassis_Menu = GameObject.Find ("Chassis_Menu");
		Engine_Menu = GameObject.Find ("Engine_Menu");

		Tire0 = GameObject.Find ("Tire0");
		Tire1 = GameObject.Find ("Tire1");
		Tire2 = GameObject.Find ("Tire2");
		Tire3 = GameObject.Find ("Tire3");
		Tire4 = GameObject.Find ("Tire4");	
		Tire5 = GameObject.Find ("Tire5");	

		DataBar1 = GameObject.Find ("DataBar1");
		DataBar2 = GameObject.Find ("DataBar2");
		DataBar3 = GameObject.Find ("DataBar3");
	}
	
	// Update is called once per frame
	void Update () {
			Clear ();
			//------------------------------------------Main Menu-------------------------------------------//
			switch (menu) {
			case 0:
				Tire_Menu.transform.position = Pos1;
				Chassis_Menu.transform.position = Pos2;
				Engine_Menu.transform.position = Pos3;
				break;
			//--------------------------------------------Tire Menu------------------------------------------//
			case 1:
				ArrowBack.transform.position = Back;
				switch (scroll) {
				case 0:
					Tire0.transform.position = Pos1;
					Tire1.transform.position = Pos2;
					Tire2.transform.position = Pos3;
					ArrowRight.transform.position = Right;
					break;
				case 1:
					Tire3.transform.position = Pos2;
					ArrowRight.transform.position = Right;
					ArrowLeft.transform.position = Left;
					break;
				case 2:
					Tire4.transform.position = Pos1;
					Tire5.transform.position = Pos2;
					ArrowLeft.transform.position = Left;
					break;
				}
				break;
			//--------------------------------------------Chassis Menu----------------------------------------------//
			case 2:
				ArrowBack.transform.position = Back;
				break;
			//--------------------------------------------Engine Menu----------------------------------------------//
			case 3:
				ArrowBack.transform.position = Back;
				break;
			}
			//--------------------------------------------------------------------------------------------//
		DrawBars();
	}

	void Clear(){
		Tire_Menu.transform.position = Storage;
		Chassis_Menu.transform.position = Storage;
		Engine_Menu.transform.position = Storage;

		Tire0.transform.position = Storage;
		Tire1.transform.position = Storage;
		Tire2.transform.position = Storage;
		Tire3.transform.position = Storage;
		Tire4.transform.position = Storage;
		Tire5.transform.position = Storage;

		ArrowLeft.transform.position = Storage;
		ArrowRight.transform.position = Storage;
		ArrowBack.transform.position = Storage;

		DataBar1.transform.position = Storage;
		DataBar2.transform.position = Storage;
		DataBar3.transform.position = Storage;
	}

	void DrawBars(){
		if (Car_Data.Looking == true) {
			DataBar1.transform.position = BarPos1;
			DataBar2.transform.position = BarPos2;
			DataBar3.transform.position = BarPos3;
			//Need to add different bar sprites for dirrent values of Car_Data.TempData1 to 3

		}
	}
}
