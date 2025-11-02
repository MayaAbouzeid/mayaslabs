using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoom : MonoBehaviour
{
private Camera Cam;
public float TragetZoom =3;
private float ScrollData;
public float ZoomSpeed=3;
    void Start()
    {
        Cam=GetComponent<Camera>();
        TragetZoom=Cam.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        ScrollData=Input.GetAxis("mouse ScrollWheel");
        TragetZoom=TragetZoom-ScrollData;
        TragetZoom=Mathf.Clamp(TragetZoom,3,6);
        Cam.orthographicSize=Mathf.Lerp(Cam.orthographicSize,TragetZoom,Time.deltaTime*ZoomSpeed);
    }
}
