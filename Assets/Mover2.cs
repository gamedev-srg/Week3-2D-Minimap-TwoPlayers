using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            Vector3 position = this.transform.position;
            position.x-= 0.015f;
            this.transform.position = position;
        }
        if (Input.GetKey("d"))
        {
            Vector3 position = this.transform.position;
            position.x += 0.015f;
            this.transform.position = position;
        }
        if (Input.GetKey("w"))
        {
            Vector3 position = this.transform.position;
            position.y += 0.015f;
            this.transform.position = position;
        }
        if (Input.GetKey("s"))
        {
            Vector3 position = this.transform.position;
            position.y -= 0.015f;
            this.transform.position = position;
        }
    }
}
