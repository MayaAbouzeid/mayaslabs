using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class cameraFloww : MonoBehaviour
{
    public Transform target;
    public float cameraSpeed;
    public float minX, maxX, minY, maxY;

    void FixedUpdate()
    {
        if (target != null)
        {
            Vector2 newCamPosition = Vector2.Lerp(transform.position, target.position, Time.deltaTime * cameraSpeed);

            float ClampX = Mathf.Clamp(newCamPosition.x, minX, maxX);
            float ClampY = Mathf.Clamp(newCamPosition.y, minY, maxY);

            transform.position = new Vector3(ClampX, ClampY, -10f);
        }
    
    }    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
