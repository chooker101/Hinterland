using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{
	//public RectTransform RotateRT;
	public Vector2 move;
<<<<<<< HEAD
	private Vector2 Mouse;
=======
	private Vector3 Mouse;
	private GameObject currArrow;
>>>>>>> 0263cc300882b7a98ff5e895df69e08ab6dc5d36
	//public Vector3 move3D;
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
		/*
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
		{*/
		if (GameManager.Instance.gmPlayer.GetComponent<Rigidbody2D>() != null)
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
		//}
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
		GameManager.Instance.gmPlayersScript.Rotate();
	}

	public void InputShootOn()
	{
		GameManager.Instance.gmReticle.SetActive(true);
		GameManager.Instance.gmPlayersScript.StartAim();
	}

	public void InputShootWhile()
	{
		Mouse.x = Input.mousePosition.x;
		Mouse.y = Input.mousePosition.y;
		Mouse.z = Input.mousePosition.z;

		GameManager.Instance.gmReticle.transform.position = Mouse;

<<<<<<< HEAD
		GameManager.Instance.gmPlayersScript.Aim(Mouse.x, Mouse.y,Input.mousePosition.z);
=======
		GameManager.Instance.gmPlayersScript.Aim(Mouse.x, Mouse.y,Mouse.z, currArrow);
>>>>>>> 0263cc300882b7a98ff5e895df69e08ab6dc5d36
	}

	public void InputShootOff()
	{
		GameManager.Instance.gmReticle.SetActive(false);
		GameManager.Instance.gmPlayersScript.Fire(Mouse.x, Mouse.y, Input.mousePosition.z);
	}
}
