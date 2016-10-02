using UnityEngine;
using System.Collections;

public class Opening : MonoBehaviour {

    public GameObject im1, im2, im3, im4;
	public GameObject Audio;
    public float pictime=5;
    float t1;
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
		this.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = true;
		Audio.GetComponent<AudioSource>().clip = bgm;
		Audio.GetComponent<AudioSource>().Play();
		Destroy (this);
	}
	void Start ()
	{       
		t1 = Time.time;
		Audio.GetComponent<AudioSource>().loop = true;
        Audio.GetComponent<AudioSource>().Play();
		StartCoroutine(WaitAndPrint(pictime,im4));
        //Destroy(im1);
		StartCoroutine(WaitAndPrint(pictime*4,im1));
        //Destroy(im2);
		StartCoroutine(WaitAndPrint(pictime*7,im2));
        //Destroy(im3);
		StartCoroutine(WaitAndPrint(pictime*8,im3));
		StartCoroutine(WaitAndDestory(pictime*8));
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
