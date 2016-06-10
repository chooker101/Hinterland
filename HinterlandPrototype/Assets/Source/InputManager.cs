using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{
	public Vector2 move;
	public bool Touch;
	private bool Up;
	private bool Down;
	private bool L;
	private bool R;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		move = Vector2.zero;
		if(!Touch)
		{
			move.y = Input.GetAxis("Vertical");
			move.x = Input.GetAxis("Horizontal");
		}
		else
		{
			if(Up)
			{
				move.y += 1;
			}
			if(Down)
			{
				move.y -= 1;
			}
			if(R)
			{
				move.x += 1;
			}
			if(L)
			{
				move.x -= 1;
			}
		}
	}

	public void UpOn()
	{
		Up = true;
	}

	public void UpOff()
	{
		Up = false;
	}

	public void DownOn()
	{
		Down = true;
	}

	public void DownOff()
	{
		Down = false;
	}

	public void RightOn()
	{
		R = true;
	}

	public void RightOff()
	{
		R = false;
	}

	public void LeftOn()
	{
		L = true;
	}

	public void LeftOff()
	{
		L = false;
	}
}
