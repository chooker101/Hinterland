using UnityEngine;
using System.Collections;

public class AimFollow : MonoBehaviour
{
	Transform cache_tf;
	Transform playerAim_tf;
	// Use this for initialization
	void Start ()
	{
		cache_tf = GetComponent<Transform>();
		playerAim_tf = GameObject.FindGameObjectWithTag("Aim").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		cache_tf.position = playerAim_tf.position;
		cache_tf.rotation = playerAim_tf.rotation;
	}
}
