using UnityEngine;

public class AppData : MonoBehaviour
{
	[SerializeField]
	int mTagetFramerate = 60;
	void Awake()
	{
		Application.targetFrameRate = mTagetFramerate;
	}
}
