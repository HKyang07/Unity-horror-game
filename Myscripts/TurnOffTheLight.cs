using UnityEngine;
using System.Collections;

public class TurnOffTheLight : MonoBehaviour {

	public GameObject EnvLight;
	public GameObject FlashLight;
	public bool IsTurnedOff = false;
	bool InMyHand = false;
	// Use this for initialization
	void Start () {		

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (InMyHand && Input.GetKeyDown("e") && !IsTurnedOff)
		{
			if (EnvLight)
				EnvLight.GetComponent<Light> ().enabled = false;
			if (FlashLight)
				FlashLight.GetComponent<Light> ().enabled = true;
			this.gameObject.GetComponent<AudioSource> ().Play();
			IsTurnedOff = true;
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
