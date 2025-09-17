using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.002f, 0f, 0f);
        if (transform.position.x <= -16.5f)
        {
            Vector3 newPosition = new Vector3(16f, 0f, 0f);
            transform.position = newPosition;
        }
    }
}
