﻿using UnityEngine;

public class Camera_follow : MonoBehaviour
{
    public Transform target;

    //public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private void LateUpdate()
    {
        if (target != null)
        transform.position = target.position + offset;  
    }
}
