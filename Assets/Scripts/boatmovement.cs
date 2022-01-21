using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatmovement : MonoBehaviour
{
    void Start()
    {
        //Debug.log("plane added to object" + gameObject.Name);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 MoveCamTo = transform.position - transform.forward * 2.0f + Vector3.up * 1.0f;

        float bias = 0.96f;
        //Camera.main.transform.position = Camera.main.transform.position * bias + MoveCamTo * (1.0f - bias);
        //Camera.main.transform.LookAt(transform.position);


        transform.position += transform.forward * Time.deltaTime * 4f;
        transform.Rotate(0, 0.0f * 0.05f, -Input.GetAxis("Horizontal") * 0.3f);


        //float terrainheigth = Terrain.activeTerrain.SampleHeight(transform.position);

        //if (terrainheigth > transform.position.y)
        //{
        //    transform.position = new Vector3(transform.position.x, terrainheigth, transform.position.z);
        //}
    }
}
