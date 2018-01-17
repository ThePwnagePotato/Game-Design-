using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar_Renderer : MonoBehaviour {

	public int Data;

	public Sprite Bar0;
	public Sprite Bar1;
	public Sprite Bar2;
	public Sprite Bar3;
	public Sprite Bar4;
	public Sprite Bar5;
	public Sprite Bar6;
	public Sprite Bar7;
	public Sprite Bar8;
	public Sprite Bar9;
	public Sprite Bar10;
	
	// Update is called once per frame
	void Update () {
		switch (Data) {
		case 0:
			this.GetComponent<SpriteRenderer> ().sprite = Bar0;
			break;
		case 1:
			this.GetComponent<SpriteRenderer> ().sprite = Bar1;
			break;
		case 2:
			this.GetComponent<SpriteRenderer> ().sprite = Bar2;
			break;
		case 3:
			this.GetComponent<SpriteRenderer> ().sprite = Bar3;
			break;
		case 4:
			this.GetComponent<SpriteRenderer> ().sprite = Bar4;
			break;
		case 5:
			this.GetComponent<SpriteRenderer> ().sprite = Bar5;
			break;
		case 6:
			this.GetComponent<SpriteRenderer> ().sprite = Bar6;
			break;
		case 7:
			this.GetComponent<SpriteRenderer> ().sprite = Bar7;
			break;
		case 8:
			this.GetComponent<SpriteRenderer> ().sprite = Bar8;
			break;
		case 9:
			this.GetComponent<SpriteRenderer> ().sprite = Bar9;
			break;
		case 10:
			this.GetComponent<SpriteRenderer> ().sprite = Bar10;
			break;
		}
	}
}
