using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMovementScript : MonoBehaviour
{
    //the speed of this object
    public float speed;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;

        newPos += transform.forward * speed * Time.deltaTime;

        transform.position = newPos;

    }
}
