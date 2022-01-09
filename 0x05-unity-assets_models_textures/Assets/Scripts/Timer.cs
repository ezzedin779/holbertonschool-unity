using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
	public Text timerText;
	private float time;
    void Update()
    {
        time += Time.deltaTime;

		var min = time /60;
		var sec = time % 60;
		var fra = (time * 100) % 100;

		timerText.text = string.Format("{0:0}:{1:00}.{2:00}", min, sec, fra);
    }
}
