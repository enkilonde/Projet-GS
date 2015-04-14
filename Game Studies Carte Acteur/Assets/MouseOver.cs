using UnityEngine;
using System.Collections;

public class MouseOver : MonoBehaviour 
{

	public Material _Material1;
	public Material _Material2;

	public GameObject _pointer;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		

		RaycastHit _hit;

		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		LayerMask _lm = LayerMask.GetMask ("Plane1");

		if (Physics.Raycast(ray, out _hit, 10000, _lm))
		{
			_pointer.transform.position = _hit.point;
			if (_hit.transform.tag == "Sphere")
			{


			}
		
		}

	}
}
