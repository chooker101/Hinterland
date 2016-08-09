using UnityEngine;
using System.Collections;

public class TopDownPlayerScript : Player
{
	public float force;
	private CameraScript cs;
	private Rigidbody2D cache_rb;
	private Animator cachen_anim;

	// Use this for initialization
	void Start ()
	{
		//Debug.Log("Start");
		cache_input = GameManager.Instance.gmInputManager;
		cache_rb = this.GetComponent<Rigidbody2D>();
		cache_tf = this.GetComponent<Transform>();
		cachen_anim = this.GetComponent<Animator>();
		cs = GameManager.Instance.gmPlayerCam.GetComponent<CameraScript>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!cs.EditMode)
		{
			cachen_anim.SetFloat("Ver", cache_input.move.y);
			cachen_anim.SetFloat("Hor", cache_input.move.x);

			cache_rb.velocity = cache_input.move * force;
		}
	}
}
