using UnityEngine;
using System.Collections;

public class Makesound : MonoBehaviour {

    bool played = false;
    public AudioClip clip1 = null;
    public GameObject cube = null;
	// Use this for initialization
	void Start () {
        if (!cube) cube=this.gameObject;
        cube.GetComponent<AudioSource>().clip = clip1;
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter(Collider other)
    {
        if (!played)
        {
            cube.GetComponent<AudioSource>().Play();
            played = true;
        }
    }
}
