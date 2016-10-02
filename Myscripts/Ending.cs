using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Ending : MonoBehaviour {

	public GameObject im1, im2, im3, im4;
	public GameObject Audio;
	public GameObject Audio2;
	public GameObject Player;
	public float pictime=5;
	public AudioClip bgm;
	// Use this for initialization
	IEnumerator WaitAndPrint(float time, GameObject im)
	{
		yield return new WaitForSeconds(time);
		Destroy (im);
	}
	IEnumerator WaitAndDestory(float time)
	{
		yield return new WaitForSeconds (time);
		//this.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = true;
		//Audio.GetComponent<AudioSource>().clip = bgm;
		//Audio.GetComponent<AudioSource>().Play();
		Destroy (this);
	}
	void Start ()
	{       
		Player.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
		im1.GetComponent<Image> ().enabled = true;
		im2.GetComponent<Image> ().enabled = true;
		im3.GetComponent<Image> ().enabled = true;
		im4.GetComponent<Image> ().enabled = true;
		Audio2.GetComponent<AudioSource> ().enabled = false;
		Audio.GetComponent<AudioSource>().clip = bgm;
		Audio.GetComponent<AudioSource>().Play();
		StartCoroutine(WaitAndPrint(pictime*2,im1));
		StartCoroutine(WaitAndPrint(pictime*4,im2));
		StartCoroutine(WaitAndPrint(pictime*6,im3));
		//StartCoroutine(WaitAndPrint(pictime*7,im4));
		//StartCoroutine (WaitAndDestory (pictime*7));
	}

	// Update is called once per frame
	void Update () {

	}
}
