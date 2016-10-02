using UnityEngine;
using System.Collections;

public class ChangeBGM : MonoBehaviour {

	public AudioClip clip;
	public GameObject player;
	bool InMyHand = false;
	public bool IsChanged = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (InMyHand && Input.GetKeyDown("e") && !IsChanged)
		{
			if (player) {
				player.GetComponent<AudioSource> ().clip = clip;
				player.GetComponent<AudioSource> ().Play ();
			}
			IsChanged = true;
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
