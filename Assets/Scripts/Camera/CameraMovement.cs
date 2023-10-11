using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Camera mainCamera;

    // Start is called before the first frame update
    void Start() { mainCamera = Camera.main; }

    // Update is called once per frame
    void Update()
    {
        MoveCamera();
        RotateCamera();
    }

    private void MoveCamera()
    {
        transform.position = Vector3.MoveTowards(
                    transform.position,
                    transform.position + (mainCamera.transform.forward * Input.GetAxis("Vertical")) + (transform.right * Input.GetAxis("Horizontal")),
                    Time.deltaTime * 10f);
    }

    private void RotateCamera()
    {
        mainCamera.transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), 0, 0));
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0));
    }
}
