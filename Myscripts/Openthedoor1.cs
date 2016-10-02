using UnityEngine;
using System.Collections;

public class Openthedoor1 : MonoBehaviour {
	public bool locked = false;
	bool open = false;
	bool imin = false, openning = false, closing = false;
	public float openangle, closeangle;
	float angle, speed =0.5f, roangle = 0,an,cha;
	//public AudioClip dooropen, doorlocked;
	//AudioSource sound;
	// Use this for initialization
	void Start () {
		//sound = this.GetComponent<AudioSource>();
		cha = Mathf.Abs(openangle-closeangle);
	}

	// Update is called once per frame
	void Update () {
		if (locked && imin && Input.GetKeyDown("e"))
		{
			//sound.clip = doorlocked;
			//sound.Play();
		}
		if (!locked&&imin && Input.GetKeyDown("e"))
		if (open)
		{
			//sound.clip = dooropen;
			//sound.Play();
			closing = true;
			openning = false;
			open = false;
			angle = closeangle - openangle;
			roangle = cha - roangle;
			if (roangle >= cha) roangle = 0;
		}
		else
		{
			//sound.clip = dooropen;
			//sound.Play();
			//this.GetComponent<AudioSource>().Play();
			openning = true;
			closing = false;
			open = true;
			angle = openangle-closeangle;
			roangle = cha - roangle;
			if (roangle >= cha) roangle = 0;
		}
		if (openning)
		{
			if (roangle < cha)
			{
				an = angle * Time.deltaTime * speed;
				roangle += Mathf.Abs(an);
				transform.Rotate(new Vector3(0, an, 0));
			}
			else
			{
				roangle = 0;
				open = true;
				openning = false;
			}
		}
		if (closing)
		{
			if (roangle < cha)
			{
				an = angle * Time.deltaTime * speed;
				roangle += Mathf.Abs(an);
				transform.Rotate(new Vector3(0, an, 0));
			}
			else
			{
				roangle = 0;
				open = false;
				closing = false;
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name=="Myself") imin = true;
		//other.gameObject.GetComponent<Renderer>().enabled = false;
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.name == "Myself") imin = false;
		//other.gameObject.GetComponent<Renderer>().enabled = true;
	}
}
