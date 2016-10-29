using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	private static GameManager s_Instance;
	public static GameManager Instance
	{
		get
		{
			if (s_Instance == null)
			{
				s_Instance = FindObjectOfType<GameManager>();
			}
			return s_Instance;
		}
	}

	public GameObject gmPlayer;
	public Player gmPlayersScript;
	public Camera gmPlayerCam;
	public InputManager gmInputManager;
	public RideScript gmRideScript;
	public GameObject gmReticle;
	//public ArrowManager gmArrowManager;
}
