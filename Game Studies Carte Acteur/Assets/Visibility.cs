using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Visibility : MonoBehaviour 
{


	public float _MeshVisibility = 1;
	public float _TextVisibility = 1;

	
	private Text _Txt;


	// Use this for initialization
	void Start () 
	{
		_Txt = transform.GetChild (0).Find ("Text").GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () 
	{

		float _AlphaAdd = (Camera.main.orthographicSize - transform.localScale.x / 20) - _TextVisibility;
		_Txt.color = new Color (_Txt.color.r, _Txt.color.g, _Txt.color.b, 1 - (_AlphaAdd));


		float _AlphaMesh = (Camera.main.orthographicSize - transform.localScale.x / 20) - _MeshVisibility;
		GetComponent<Renderer> ().material.color = new Color (GetComponent<Renderer> ().material.color.r, GetComponent<Renderer> ().material.color.g, GetComponent<Renderer> ().material.color.b, 1 - (_AlphaMesh));
		print (GetComponent<Renderer> ().material.color.a);
	}
}
