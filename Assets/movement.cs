using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public float zForce = 2000f;
    public float xForce = 2000f;

    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, xForce * Time.deltaTime);
            
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-zForce * Time.deltaTime, 0, 0);
            GetComponent<Transform>().eulerAngles = new Vector3(90, -45, 0);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -xForce * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(zForce * Time.deltaTime, 0, 0);
            GetComponent<Transform>().eulerAngles = new Vector3(90, 45, 0);
        }

        if (!Input.GetKey("a") && !Input.GetKey("d"))
        {
            GetComponent<Transform>().eulerAngles = new Vector3(90, 0, 0);

        }
    }
}

