using UnityEngine;
using TMPro;
public class DebugInfo : MonoBehaviour
{
	[SerializeField]
	TMP_Text mText;
	[SerializeField]
	int mCount = 10;
	[SerializeField]
	float slow = 0.5f;
	float fps;
	float fpsCounter;
	void Update()
	{
		bool isModify = false;
		if(Input.GetKeyDown(KeyCode.Space))
		{
			if(Time.timeScale == 1.0f)
			{
				Time.timeScale = slow;
			}
			else
			{
				Time.timeScale = 1.0f;
			}
			isModify = true;
		}
		fpsCounter += Time.timeScale / Time.deltaTime;
		if(Time.frameCount % mCount == 0)
		{
			fps = fpsCounter / (float)mCount;
			fpsCounter = 0.0f;
			isModify = true;
		}
		if(isModify)
		{
			mText.text = $"fps:{fps:f2}, TimeScale:{Time.timeScale:f2}";
		}
	}
}
