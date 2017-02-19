using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void callButton(){
		AndroidJavaClass unity = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
		AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject> ("currentActivity");
		AndroidJavaClass jc = new AndroidJavaClass("com.clover.unityplugforblog.NextActivity");
		// Calling a Call method to which the current activity is passed
		jc.CallStatic("Call", currentActivity);
		//currentActivity.Call ("jump_view");

		AndroidJavaObject context = currentActivity.Call<AndroidJavaObject>("getApplicationContext");
	}
}
