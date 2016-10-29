using UnityEngine;
using System.Collections;

public class ArrowManager : MonoBehaviour
{
	[SerializeField]
	private GameObject[] arrows;
	[SerializeField]
	int currArrow;

	public GameObject GetArrow()
	{
		return arrows[currArrow];
	}

	public void IncrArrow()
	{
		if (currArrow < arrows.Length)
		{
			++currArrow;
		}
		else
		{
			currArrow = 0;
		}
	}
}
