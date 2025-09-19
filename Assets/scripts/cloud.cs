using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour
{
    public float speed = 0.005f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-speed, 0f, 0f);
        if (transform.position.x < -14f)
        {
            Vector3 newPosition = new Vector3(14f, 0f, 0f);
            transform.position = newPosition;
        }
    }
}
