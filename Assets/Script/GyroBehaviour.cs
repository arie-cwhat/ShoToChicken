using UnityEngine;
using System.Collections;

public class GyroBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Input.gyro.enabled = true;
		Input.gyro.updateInterval = 0.01F;

		Debug.Log(Input.gyro.enabled);
	}
	
	void Update () {
		Vector3 v = Input.gyro.rotationRateUnbiased;
		transform.Rotate(-v.x, -v.y, v.z);
	}

}
