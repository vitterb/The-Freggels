using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdMovement : MonoBehaviour
{

    public CharacterController Controller;

    public float speed = 6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical);

        if (direction.magnitude >= 0.1f)
        {
            Controller.Move(direction * speed * Time.deltaTime);
        }
    }
}
