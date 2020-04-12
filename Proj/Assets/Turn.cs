using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            if (this.GetComponent<Light>().enabled == false)
            {
                this.GetComponent<Light>().enabled = true;
            }
            else
            {
                this.GetComponent<Light>().enabled = false;
            }
    }
}
