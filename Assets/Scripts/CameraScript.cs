using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject John;
   
    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.x =John.transform.position.x;
        transform.position = position;
    }
}
