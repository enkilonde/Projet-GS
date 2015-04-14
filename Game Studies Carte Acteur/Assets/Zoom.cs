using UnityEngine;
using System.Collections;

public class Zoom : MonoBehaviour 
{

	public float _ZoomSizeWanted = 10;
	public Vector3 _PosWanted = Vector3.zero;
	public Camera _camera;

	public float _ZoomIncrease = 1;
	public Vector3 _Direction;


	public float _initDist = 0;
	public float _frameDist = 0;

	public bool _Zoom;
	public bool _Move;

	void Start () 
	{
		_camera = GetComponent<Camera> ();
		_ZoomSizeWanted = _camera.orthographicSize;
		_PosWanted = transform.position;


	}

	void Update () 
	{

		_Zoom = _camera.orthographicSize != _ZoomSizeWanted;
		_Move = transform.position != _PosWanted;

		if (_camera.orthographicSize != _ZoomSizeWanted)
		{
			_camera.orthographicSize += _ZoomIncrease;
		}

		if (transform.position != _PosWanted) 
		{
			transform.position += _Direction;
		}



		if (Mathf.Abs(_camera.orthographicSize - _ZoomSizeWanted) < Mathf.Abs(_ZoomIncrease) * 2) 
		{
			_camera.orthographicSize = _ZoomSizeWanted;
		}

		float RemainingDistance = Vector3.Distance (transform.position, _PosWanted);
		if (RemainingDistance < _Direction.magnitude * 2) 
		{
			transform.position = _PosWanted;
		}



		if (Input.GetMouseButtonDown (1)) 
		{

			ZoomToWanted(5, new Vector3(0, 10, 0), 20);


		}



	}


	public void ZoomToWanted(float _Zoom, Vector3 _Pos, float _NumberOfFrames = 100)
	{

		_ZoomSizeWanted = _Zoom;
		_PosWanted = _Pos;

		_ZoomIncrease = ((_Zoom - Camera.main.orthographicSize) / _NumberOfFrames);

		Vector3 _dir = _PosWanted - transform.position;
		_initDist = _dir.magnitude;
		_Direction = _dir / _NumberOfFrames;
		_frameDist = _Direction.magnitude;
	}


}
