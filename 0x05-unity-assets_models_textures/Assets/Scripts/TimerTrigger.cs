using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    public GameObject player;

	void OnTriggerExit(Collider other)
	{
		player.GetComponent<Timer>().enabled = true;
	}
}
