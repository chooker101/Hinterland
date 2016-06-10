using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
	public float force;
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
	}
	
	// Update is called once per frame
	void Update ()
	{
		cachen_anim.SetFloat("Ver", cache_input.move.y);
		cachen_anim.SetFloat("Hor", cache_input.move.x);

		cache_rb.velocity = cache_input.move * force;
	}
}
