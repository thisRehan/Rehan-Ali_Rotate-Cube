using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] int speed = 40;
    private Vector3 AddScale = new Vector3(0.1f, 0.1f, 0.1f);
    private Vector3 ActualScale;

    private void Start()
    {
        ActualScale = transform.localScale;
    }
    void Update()
    {
        ControlCube();
    }

    void ControlCube()
    {
        xAxisRotation(speed);
        yAxisRotation(speed);
        zAxisRotation(speed);
        Scaling(AddScale);
    }

    void xAxisRotation(int speed)
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.right * speed * Time.deltaTime * horizontalInput);
    }
    void yAxisRotation(int speed)
    {
        float verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up * Time.deltaTime * verticalInput * speed);
    }
    void zAxisRotation(int speed)
    {
        if (Input.GetKey(KeyCode.Z))
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
    void Scaling(Vector3 AddScale)
    {
        if (Input.GetKey(KeyCode.Space))
            transform.localScale = transform.localScale + AddScale;
        else
            transform.localScale = ActualScale;
    }

}
