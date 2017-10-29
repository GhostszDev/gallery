using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(statsManager))]
public class player : MonoBehaviour {

    public Image img;
    public Camera cam;
    float speed = 35.0f;

	// Use this for initialization
	void Start () {

        Cursor.lockState = CursorLockMode.Locked;

	}
	
	// Update is called once per frame
	void Update () {

#if UNITY_ANDROID || UNITY_IOS

        mobileControls();

#else

        controllerControls();

#endif



    }

    void mobileControls() {

        Vector3 dir = Vector3.zero;
        dir.x = -Input.acceleration.y;
        dir.y = Input.acceleration.x;
        if (dir.sqrMagnitude > 1){

            dir.Normalize();
        }

        dir *= Time.deltaTime;
        transform.Translate(dir * speed);

    }

    void controllerControls() {

        Vector3 dir = Vector3.zero;

        dir.x = -Input.GetAxis("Mouse Y");
        dir.y = 0;
        dir.z = 0;

        dir *= Time.deltaTime;
        cam.transform.Rotate(dir * speed);

        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * speed * Time.deltaTime);
    }
}
