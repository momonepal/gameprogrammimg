using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseCamera : MonoBehaviour
{
    public float sensitivity = 10;


    float verticalAngle = 0;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	Vector3  horizontalRotation = new Vector3(0, Input.GetAxis("Mouse X") * sensitivity, 0);
    	transform.Rotate(horizontalRotation, Space.Self);

        verticalAngle += Input.GetAxis("Mouse Y") * -sensitivity;
        verticalAngle = Mathf.Clamp(verticalAngle, -88, 88);

        transform.localEulerAngles = new Vector3( verticalAngle, transform.localEulerAngles.y , 0 );        
    }
}
