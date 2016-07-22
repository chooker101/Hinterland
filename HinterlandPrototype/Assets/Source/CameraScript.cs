using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour
{
	public GameObject player;
	public bool EditMode;
	public float camspeed;
	[SerializeField]
	private float pullbackdist;
	[SerializeField]
	private Vector3 place;
	private Transform cache_tf;
	private Rigidbody2D cache_rb;
	private Transform playertcache;
	private InputManager inputcache;
	private bool once = false;

	// Use this for initialization
	void Start()
	{
		cache_tf = this.GetComponent<Transform>();
		cache_rb = this.GetComponent<Rigidbody2D>();
		playertcache = player.GetComponent<Transform>();
		inputcache = player.GetComponent<InputManager>();
		cache_tf.LookAt(playertcache);
	}

	// Update is called once per frame
	void Update()
	{
		if (!EditMode)
		{
			cache_tf.position = place + playertcache.position;
			cache_tf.LookAt(playertcache);
			once = true;
		}
		else
		{
			if (once)
			{
				Vector3 temp = cache_tf.position;
				temp.z -= pullbackdist;
				temp.y -= pullbackdist;
				cache_tf.position = temp;
				once = false;
			}
			cache_rb.velocity = inputcache.move * camspeed;
		}
	}
}
