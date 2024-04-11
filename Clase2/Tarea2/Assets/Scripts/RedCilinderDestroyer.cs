using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RedCilinderDestroyer : MonoBehaviour
{

    public Rigidbody MyRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision myRigidbody)
    {
        //Si el objeto que ha colisionado tiene una etiqueta especifica

        if (myRigidbody.gameObject.name =="Cylinder (1)")
        {
            Destroy(myRigidbody.gameObject);
        }
    }
}
