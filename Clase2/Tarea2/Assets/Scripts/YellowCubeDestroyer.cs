using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class YellowCubeDestroyer : MonoBehaviour
{
    private byte cont = 0;
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

        if (myRigidbody.gameObject.name =="YellowCube1" || myRigidbody.gameObject.name =="YellowCube2"|| myRigidbody.gameObject.name =="YellowCube3"|| myRigidbody.gameObject.name =="YellowCube4" || myRigidbody.gameObject.name =="YellowCube5")
        {
            Destroy(myRigidbody.gameObject);
            cont++;
        }
       else if (myRigidbody.gameObject.name == "Cylinder1" || myRigidbody.gameObject.name == "Cylinder2" ||
                myRigidbody.gameObject.name == "Cylinder3" || myRigidbody.gameObject.name == "Cylinder4" ||
                myRigidbody.gameObject.name == "Cylinder5" || myRigidbody.gameObject.name == "Cylinder6" ||
                myRigidbody.gameObject.name == "Cylinder7" || myRigidbody.gameObject.name == "Cylinder8" ||
                myRigidbody.gameObject.name == "Cylinder9")
        {
            Destroy(this.gameObject);//El this reemplaza 
            Debug.Log("Oh no!!!");
        }
        
        else if (myRigidbody.gameObject.name == "Tope")
        {
            print(cont);
        }
        
    }


    
}
