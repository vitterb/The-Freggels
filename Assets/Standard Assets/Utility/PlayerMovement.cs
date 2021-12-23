using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
    public float xspeed = 30;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = CrossPlatformInputManager.GetAxis("Horizontal");
        float xOffset = horizontal * Time.deltaTime * xspeed;
        float NewX = xOffset + transform.localPosition.x;
        transform.localRotation = Quaternion.Euler(0, 0, 0);
        transform.localPosition = new Vector3(Mathf.Clamp(NewX, -50, 50), transform.localPosition.y, transform.localPosition.z);

        //float vertical = CrossPlatformInputManager.GetAxis("Vertical");
        //float yOffset = vertical + transform.localPosition.y;
        //float NewY = yOffset + transform.localPosition.y;
        //transform.localRotation = Quaternion.Euler(0, 0, 0);
        //transform.localPosition = new Vector3(Mathf.Clamp(NewY, -50, -50), transform.localPosition.x, transform.localPosition.z);

    }
}