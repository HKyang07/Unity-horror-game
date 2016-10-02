using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpecialGetme2 : MonoBehaviour {

	public bool inmyhand = false;
	public bool boxlocked = false;
	// Use this for initialization
	public GameObject door=null;
	public float rotatex = 0;
	public float rotatey = 0;
	public float rotatez = 0;
	public GameObject doll = null;
	public GameObject doll1 = null;
	public GameObject doll2 = null;
	public GameObject doll3 = null;
	public GameObject doll4 = null;
	bool Isrotate = false;
	public GameObject pic=null;
	public GameObject pic2=null; //suo zhe de shi hou bo fang de
	public GameObject whoskey=null; //zhe ba yao shi yong lai kai shui
	float time1;
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (inmyhand && Input.GetKeyDown("e"))
		{
			//transform.parent = eye.transform;
			//Debug.Log(transform.parent.name);
			//transform.localPosition = new Vector3(0, 0, 1);
			if (boxlocked) 
			{
				if (pic2)
					pic2.GetComponent<Image> ().enabled = true;
			}
			else 
			{
				if (door) door.GetComponent<Openthedoor>().locked = false;
				if (pic) pic.GetComponent<Image>().enabled = true;
				if (whoskey) whoskey.GetComponent<Getme>().boxlocked = false;
			}
		}
		if (boxlocked)
		{
			if (pic2.GetComponent<Image> ().enabled && Input.GetKeyDown ("q")) 
			{
				Debug.Log("3");
				pic2.GetComponent<Image> ().enabled = false;
			}
			//Destroy(this.gameObject);
		}
		else
		{
			if (pic.GetComponent<Image>().enabled && Input.GetKeyDown("q"))
			{
				
				if (doll&&!Isrotate) 
				{
					doll.transform.Rotate (new Vector3 (rotatez, rotatex, rotatey));
					Isrotate = true;
					if (doll1)
						doll1.GetComponent<MeshRenderer> ().enabled = true;
					if (doll2)
						doll2.GetComponent<MeshRenderer> ().enabled = true;
					if (doll3)
						doll3.GetComponent<MeshRenderer> ().enabled = true;
					if (doll4)
						doll4.GetComponent<MeshRenderer> ().enabled = true;
					if (doll1)
						doll1.GetComponent<MeshCollider> ().enabled = true;
					if (doll2)
						doll2.GetComponent<MeshCollider> ().enabled = true;
					if (doll3)
						doll3.GetComponent<MeshCollider> ().enabled = true;
					if (doll4)
						doll4.GetComponent<MeshCollider> ().enabled = true;
				}
				pic.GetComponent<Image>().enabled = false;
				//Destroy(this.gameObject);
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "Myself") inmyhand = true;
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.name == "Myself") inmyhand = false;
	}
}
