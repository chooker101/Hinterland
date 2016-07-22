using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{
	public RectTransform RotateRT;
	public Vector2 move;
	public Vector3 move3D;
	public bool Touch;
	private bool Up;
	private bool Down;
	private bool L;
	private bool R;
	private FPSPlayerScript player3D;

	// Use this for initialization
	void Start ()
	{

		if (this.GetComponent<FPSPlayerScript>() != null)
		{
			player3D = this.GetComponent<FPSPlayerScript>();
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (this.GetComponent<Rigidbody>() != null)
		{
			move3D = Vector3.zero;
			if (!Touch)
			{
				move3D.z = Input.GetAxis("Vertical");
				move3D.x = Input.GetAxis("Horizontal");
			}
			else
			{
				if (Up)
				{
					move3D.z += 1;
				}
				if (Down)
				{
					move3D.z -= 1;
				}
				if (R)
				{
					move3D.x += 1;
				}
				if (L)
				{
					move3D.x -= 1;
				}
			}
		}
		else
		{
			move = Vector2.zero;
			if (!Touch)
			{
				move.y = Input.GetAxis("Vertical");
				move.x = Input.GetAxis("Horizontal");
			}
			else
			{
				if (Up)
				{
					move.y += 1;
				}
				if (Down)
				{
					move.y -= 1;
				}
				if (R)
				{
					move.x += 1;
				}
				if (L)
				{
					move.x -= 1;
				}
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

	public void InputRotate()
	{
		player3D.Rotate();
	}
}
