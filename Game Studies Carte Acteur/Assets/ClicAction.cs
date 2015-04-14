using UnityEngine;
using System.Collections;

public class ClicAction : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}


	public void MoveHere(GameObject _Target)
	{

		Camera.main.GetComponent<Zoom> ().ZoomToWanted (_Target.transform.localScale.x/20, new Vector3(_Target.transform.position.x, Camera.main.transform.position.y, _Target.transform.position.z));
	}


}
