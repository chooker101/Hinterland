using UnityEngine;
using System.Collections;
using System;

public class RideScript : MonoBehaviour
{
	private enum State : uint
	{
		ExecPoints
	}

	[SerializeField]
	private float mindistance;
	[SerializeField]
	private Transform[] targets;
	[SerializeField]
	private int currTarget;
	[SerializeField]
	private uint state;
	//private Transform cache_tf;

	private NavMeshAgent cache_nav;
	private Transform cache_tf;

	// Use this for initialization
	void Start()
	{
		cache_nav = this.GetComponent<NavMeshAgent>();
		cache_tf = this.GetComponent<Transform>();
		CheckCurrentState();
	}

	// Update is called once per frame
	void Update()
	{
		RunCurrentState();
	}

	public void RunCurrentState()
	{
		switch (state)
		{
			case (uint)State.ExecPoints:
			{
					if(cache_nav.remainingDistance <= mindistance)
					{
						CheckCurrentState();
					}
					break;
			}
			default:
			{
					break;
			}
		}
	}

	public void CheckCurrentState()
	{
		switch(state)
		{
			case (uint)State.ExecPoints:
			{
					if(currTarget < targets.Length)
					{
						// raycast down get perp of hills normal
						cache_nav.SetDestination(targets[currTarget].position);
						++currTarget;
					}
					else
					{
						cache_nav.Stop();
						state++;
					}
					break;
			}
			default:
			{
					break;
			}
		}
	}
}
