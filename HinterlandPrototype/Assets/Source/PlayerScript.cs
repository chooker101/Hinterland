using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
	public float force;
	private Rigidbody2D cache_rb;
	private Transform cache_tf;
	private Animator cachen_anim;
	private Vector2 move;

	// Use this for initialization
	void Start ()
	{
		move = Vector2.zero;
		cache_rb = this.GetComponent<Rigidbody2D>();
		cache_tf = this.GetComponent<Transform>();
		cachen_anim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		move.x = Input.GetAxis("Horizontal");
		move.y = Input.GetAxis("Vertical");
		cachen_anim.SetFloat("Ver", move.y);
		cachen_anim.SetFloat("Hor", move.x);

		cache_rb.velocity = move * force;
	}
}
