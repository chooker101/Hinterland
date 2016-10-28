using UnityEngine;
using UnityEngine.Rendering;
using System.Collections;

public class FPSPlayerScript : Player
{
	public float XSensitivity = 2f;
	public bool smooth;
	public float smoothTime = 5f;
	public float ridingheight;

	private Vector3 move3d;
	private Vector3 aim3d;
	private Transform cache_ridetf;
	private Quaternion targetRot;

	private Ray mouseRay;
	private RaycastHit mouseRayHit;

	private GameObject currArrow;

	// Use this for initialization
	void Start ()
	{
		cache_input = GameManager.Instance.gmInputManager;
		cache_tf = this.GetComponent<Transform>();
		cache_ridetf = GameManager.Instance.gmRideScript.gameObject.GetComponent<Transform>();
		targetRot = cache_tf.localRotation;
	}
	
	// Update is called once per frame
	void LateUpdate ()
	{
		move3d = cache_ridetf.position;
		move3d.y += ridingheight;
		cache_tf.position = move3d;
	}

	public override void Rotate()
	{
		float xAxis = Input.GetAxis("Mouse X");
		//float xAxis = Input.mousePosition.x;

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

	public override void Aim(float mx, float my, float mz, GameObject arrow)
	{
		aim3d.x = mx;
		aim3d.y = my;
		aim3d.z = mz;
		//arrow.GetComponent<Transform>().LookAt(aim3d);
		mouseRay = GameManager.Instance.gmPlayerCam.GetComponent<Camera>().ScreenPointToRay(aim3d);
		if(Physics.Raycast(mouseRay,out mouseRayHit,100.0f,(1 << 9)))//,LayerMask.NameToLayer("Default")
		{
			//Debug.DrawRay(GameManager.Instance.gmPlayerCam.transform.position,mouseRayHit.point,Color.blue,3.0f);
			arrow.transform.LookAt(mouseRayHit.point);
			//Debug.Log("Hit");
		}
		//Debug.Log(mx + " " + my);
	}

	public override void Fire(float mx, float my,float mz)
	{
		
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
