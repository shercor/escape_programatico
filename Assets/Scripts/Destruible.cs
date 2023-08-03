using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Destruible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1) && !EventSystem.current.IsPointerOverGameObject()) // "1" represents the right mouse button
        {
            // Code to execute when right-click is detected
            Debug.Log("Right-click detected!");
            //Destroy(this.gameObject, 0f);
        }
    }
}
