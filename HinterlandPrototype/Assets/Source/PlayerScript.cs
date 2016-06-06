using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
	public float force;
	private Rigidbody2D cache_rb;
	private Transform cache_tf;
	private Animator cachen_anim;

	// Use this for initialization
	void Start ()
	{
		cache_rb = this.GetComponent<Rigidbody2D>();
		cache_tf = this.GetComponent<Transform>();
		cachen_anim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector2 move = Vector2.zero;
		move.x = Input.GetAxis("Horizontal");
		move.y = Input.GetAxis("Vertical");
		cachen_anim.SetFloat("Ver", move.y);
		cachen_anim.SetFloat("Hor", move.x);

		cache_rb.velocity = move * force;
		
	}
}
