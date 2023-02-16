using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform TargetCamera;
    public float smoothspeed;
    public Vector3 offset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, 0f, 5.5f),
            Mathf.Clamp(transform.position.y, -2f, 1.5f),
            transform.position.z);
    }

    private void FixedUpdate()
    {
        Vector3 positioncamera = TargetCamera.localPosition + offset;
        Vector3 smoothCamera = Vector3.Lerp(transform.position, positioncamera, smoothspeed);
        transform.position = smoothCamera;
    }
}
