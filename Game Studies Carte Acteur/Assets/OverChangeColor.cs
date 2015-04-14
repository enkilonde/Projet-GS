using UnityEngine;
using System.Collections;

public class OverChangeColor : MonoBehaviour {

	public Material _Material1;
	public Material _Material2;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider _coll)
	{
		if (_coll.tag == "Pointer") 
		{
			GetComponent<Renderer>().material = _Material2;




		}

	}


	void OnTriggerExit(Collider _coll)
	{
		if (_coll.tag == "Pointer") 
		{
			GetComponent<Renderer>().material = _Material1;
			
			
			
			
		}
		
		
		
	}

}
