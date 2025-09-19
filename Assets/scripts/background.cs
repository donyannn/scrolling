using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    public float speed = 0.002f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-speed, 0f, 0f);
        if (transform.position.x <= -16.5f)
        {
            Vector3 newPosition = new Vector3(16f, 0f, 0f);
            transform.position = newPosition;
        }
    }
}
