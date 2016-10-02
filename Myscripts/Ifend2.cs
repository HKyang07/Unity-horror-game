using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Ifend2 : MonoBehaviour {

	bool InMyHand = false;
	public bool IsEnd = false;
	public GameObject cube = null;
	public GameObject pic = null;
	public float pictime = 3;
	IEnumerator WaitAndPrint(float time, GameObject im)
	{
		yield return new WaitForSeconds(time);
		Destroy (im);
		this.GetComponent<Ending> ().enabled = true;
		IsEnd = true;
		Destroy (this);
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (InMyHand && Input.GetKeyDown("e") && !IsEnd)
		{
			if (pic)
				pic.GetComponent<Image> ().enabled = true;
			if (cube)
				cube.GetComponent<AudioSource> ().Play ();
			StartCoroutine (WaitAndPrint (pictime, pic));
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "Myself") InMyHand = true;
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.name == "Myself") InMyHand = false;
	}
}
