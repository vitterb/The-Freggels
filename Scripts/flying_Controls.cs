using UnityEngine;

public class flying_Controls : MonoBehaviour
{
    public float
        forewardSpeed = 25f,
        strafeSpeed = 7.5f,
        LookRotationSpeed = 90f;
    private float
        activeForewardSpeed,
        activeStrafeSpeed;
    private float
        forwardAcceleration = 2.5f,
        strafeAcceleration = 2f;  
    
    void Start()
    {
        
    }

    
    void Update()
    {
        activeForewardSpeed = Mathf.Lerp(activeForewardSpeed, Input.GetAxisRaw("Vertical") * forewardSpeed, forwardAcceleration * Time.deltaTime);
        activeStrafeSpeed = Mathf.Lerp(activeStrafeSpeed, Input.GetAxisRaw("Horizontal") * strafeSpeed, strafeAcceleration * Time.deltaTime);
      
        transform.position += transform.forward * activeForewardSpeed * Time.deltaTime;
        transform.position += transform.right * activeStrafeSpeed * Time.deltaTime;

    }
}
