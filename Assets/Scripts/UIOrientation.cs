using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIOrientation : MonoBehaviour
{
    private Transform XRCamera;
    // Start is called before the first frame update
    void Start()
    {
        XRCamera = Camera.main.transform;  
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(XRCamera);  
    }
}
