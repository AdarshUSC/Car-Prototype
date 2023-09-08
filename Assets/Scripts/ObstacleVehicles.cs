using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleVehicles : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 25.0f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}
