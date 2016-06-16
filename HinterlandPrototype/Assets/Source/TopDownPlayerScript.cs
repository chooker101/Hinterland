using UnityEngine;
using System.Collections;

public class TopDownPlayerScript : MonoBehaviour
{
	public float force;
	public GameObject cam;
	private CameraScript cs;
	private Rigidbody2D cache_rb;
	private Transform cache_tf;
	private Animator cachen_anim;
	private InputManager cache_input;

	// Use this for initialization
	void Start ()
	{
		cache_input = this.GetComponent<InputManager>();
		cache_rb = this.GetComponent<Rigidbody2D>();
		cache_tf = this.GetComponent<Transform>();
		cachen_anim = this.GetComponent<Animator>();
		cs = cam.GetComponent<CameraScript>();
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
