using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float spinSpeed = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(45f, 30f, -30f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, spinSpeed, 0) * Time.deltaTime, Space.World);
    }
}
