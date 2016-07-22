using UnityEngine;
using System.Collections;

public class FPSPlayerScript : Player
{
	public GameObject cam;
	public float XSensitivity = 2f;
	public float zforce;
	public float xforce;
	public bool smooth;
	public float smoothTime = 5f;
	private Rigidbody cache_rb;
	private Transform cache_tf;
	private Quaternion targetRot;

	// Use this for initialization
	void Start ()
	{
		cache_input = this.GetComponent<InputManager>();
		cache_rb = this.GetComponent<Rigidbody>();
		cache_tf = this.GetComponent<Transform>();
		targetRot = cache_tf.localRotation;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 forw = cache_tf.forward * cache_input.move3D.z * zforce;
		Vector3 strafe = cache_tf.right * cache_input.move3D.x * xforce;
		cache_rb.velocity = resultant(forw,strafe);
	}

	public void Rotate()
	{
		float xAxis = Input.GetAxis("Mouse X");
		float xPos = Input.mousePosition.x;

		Debug.Log(cache_input.RotateRT.rect.xMin + " " + xPos);
		if (cache_input.RotateRT.rect.xMin <= xPos)
		{
			float yRot = xAxis * XSensitivity;

			targetRot *= Quaternion.Euler(0f, yRot, 0f);

			if (smooth)
			{
				cache_tf.localRotation = Quaternion.Slerp(cache_tf.localRotation, targetRot, smoothTime * Time.deltaTime);
			}
			else
			{
				cache_tf.localRotation = targetRot;
			}
		}
	}

	private Vector3 resultant(Vector3 a, Vector3 b)
	{
		Vector3 result;
		result.x = a.x + b.x;
		result.y = a.y + b.y;
		result.z = a.z + b.z;
		return result;
	}
}
