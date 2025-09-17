using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.005f, 0f, 0f);
        if (transform.position.x < -14f)
        {
            Vector3 newPosition = new Vector3(14f, 0f, 0f);
            transform.position = newPosition;
        }
    }
}
