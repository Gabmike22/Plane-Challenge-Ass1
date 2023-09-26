using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    public float spinSpeed = 10.0f;
    private float spinPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spinPosition = Input.GetAxis("Horizontal");

        transform.Rotate(0, 0, 90 * Time.deltaTime * spinPosition * spinSpeed);
    }
}
