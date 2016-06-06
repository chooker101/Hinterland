using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour
{
	public GameObject player;
	[SerializeField]
	private Vector3 place;
	private Transform cachedtrans;
	private Transform playertcache;

	// Use this for initialization
	void Start ()
	{
		cachedtrans = this.GetComponent<Transform>();
		playertcache = player.GetComponent<Transform>();
		cachedtrans.LookAt(playertcache);
	}
	
	// Update is called once per frame
	void Update ()
	{
		cachedtrans.position = place + playertcache.position;
	}
}
