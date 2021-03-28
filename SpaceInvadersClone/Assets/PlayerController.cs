using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float XRange = 10;
    public float ZRangeMax = 10;
    public float ZRangeMin = -1;
    public float Speed = 10;
    private float horizontalInput;
    private float horizontal1Input;
    void Update()
    {
        if (transform.position.x < -XRange)
        {
            transform.position = new Vector3(-XRange, transform.position.y , transform.position.z);
        }
        
        if (transform.position.x > XRange)
        {
            transform.position = new Vector3(XRange, transform.position.y , transform.position.z);
        }
        if  (transform.position.z < ZRangeMin)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, ZRangeMin);
        }
        if (transform.position.z > ZRangeMax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, ZRangeMax);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        horizontal1Input = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * horizontal1Input * Time.deltaTime * Speed);
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * Speed);
    }
}