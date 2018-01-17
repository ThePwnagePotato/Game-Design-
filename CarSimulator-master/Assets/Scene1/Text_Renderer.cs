using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text_Renderer : MonoBehaviour {

	public int Menu;

	public Sprite Inertia;
	public Sprite Steering;
	public Sprite Grip;

	public Sprite Drag;
	public Sprite Mass;
	public Sprite Durability;

	public Sprite Acceleration;
	public Sprite Top_Speed;

	string textname;

	void Start(){
		textname = this.name;
	}
	
	// Update is called once per frame
	void Update () {
		if (string.Compare (textname, "Text1") == 0) {
			switch (Menu) {
			case 1:
				this.GetComponent<SpriteRenderer> ().sprite = Inertia;
				break;
			case 2:
				this.GetComponent<SpriteRenderer> ().sprite = Drag;
				break;
			case 3:
				this.GetComponent<SpriteRenderer> ().sprite = Acceleration;
				break;
			}
		}

		if (string.Compare (textname, "Text2") == 0) {
			switch (Menu) {
			case 1:
				this.GetComponent<SpriteRenderer> ().sprite = Steering;
				break;
			case 2:
				this.GetComponent<SpriteRenderer> ().sprite = Mass;
				break;
			case 3:
				this.GetComponent<SpriteRenderer> ().sprite = Top_Speed;
				break;
			}
		}

		if (string.Compare (textname, "Text3") == 0) {
			switch (Menu) {
			case 1:
				this.GetComponent<SpriteRenderer> ().sprite = Grip;
				break;
			case 2:
				this.GetComponent<SpriteRenderer> ().sprite = Durability;
				break;
			}
		}
	}
}
