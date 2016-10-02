using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpecialGetme : MonoBehaviour {

	public bool inmyhand = false;
	public bool boxlocked = false;
	// Use this for initialization
	public GameObject door=null;
	public GameObject deng = null;
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
			if (pic2.GetComponent<Image>().enabled&&Input.GetKeyDown("q"))
				pic2.GetComponent<Image>().enabled = false;
			//Destroy(this.gameObject);
		}
		else
		{
			if (pic.GetComponent<Image>().enabled&& Input.GetKeyDown ("q")) 
			{
				if (deng&&pic.GetComponent<Image> ().enabled)
					Destroy (deng);
				
				pic.GetComponent<Image> ().enabled = false;
			}
			//Destroy(this.gameObject);
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