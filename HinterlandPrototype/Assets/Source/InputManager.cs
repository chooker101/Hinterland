using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{
	public Vector2 move;
	public bool Touch;
	public bool UpOn;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Touch)
		{
			if(UpOn)
			{
				move.y = 1;
			}
		}
		else
		{
			move.y = Input.GetAxis("Vertical");
			move.x = Input.GetAxis("Horizontal");
		}
	}
}
