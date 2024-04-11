using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling : MonoBehaviour
{
    public Rigidbody myRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>(); // Desactivar la gravedad al inicio
        myRigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        StartGravity();
    }
    
    
    //GEnero un nuevo metodo para comenzar la gravedad
    public void StartGravity()
    {
        // Pregunto si toque el boton space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.useGravity = true;
        }
    }
}
