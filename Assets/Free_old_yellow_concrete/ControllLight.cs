#region Using
	using UnityEngine;
	using System.Collections;
#endregion

public class ControllLight : MonoBehaviour {

#region Variable
	public Camera cam;
	public Transform target;
	public float speedX = 10f;
	public float speedY = 10f;
#endregion

	#region Update
	void Update () {
		var mx = Input.GetAxis ("Mouse X");
		var my = Input.GetAxis ("Mouse Y");
		transform.Rotate (mx * speedX, my * speedY, 0);
		//transform.LookAt (target);
	}
	#endregion
}
