using UnityEngine;

public class openurl : MonoBehaviour
{
    public string url;

	public void Open()
	{
		Application.OpenURL(url);
	}
}
