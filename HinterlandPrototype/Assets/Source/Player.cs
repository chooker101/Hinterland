using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	protected InputManager cache_input;
	protected Transform cache_tf;

	public virtual void Rotate()
	{

	}

<<<<<<< HEAD
	public virtual void StartAim()
=======
	public virtual void Aim(float mx,float my, float mz,GameObject arrow)
>>>>>>> 0263cc300882b7a98ff5e895df69e08ab6dc5d36
	{

	}

<<<<<<< HEAD
	public virtual void Aim(float mx,float my,float mz)
	{

	}

=======
>>>>>>> 0263cc300882b7a98ff5e895df69e08ab6dc5d36
	public virtual void Fire(float mx,float my,float mz)
	{

	}
}
