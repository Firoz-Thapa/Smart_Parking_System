using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{ 
    public GameObject objectToInstantiate;
    public Transform spawner;

    void Start()
    {

        if (spawner == null)
        {
            Debug.LogError("Spawn Point is not assigned to the script.");
        }
    }

    public void OnButtonClick()
    {

        if (objectToInstantiate != null && spawner != null)
        {
           
            GameObject instantiatedObject = Instantiate(objectToInstantiate, spawner.position, spawner.rotation);
            instantiatedObject.tag="Not Detected Car";
            CameraFollow cameraFollow = GameObject.Find("Main Camera").GetComponent<CameraFollow>();
            cameraFollow.carTransform=instantiatedObject.transform;
           
            Rigidbody carRigidbody = instantiatedObject.GetComponent<Rigidbody>();

     
            if (carRigidbody != null)
            {
              
                carRigidbody.useGravity = true;
                carRigidbody.isKinematic = false;
            }
            else
            {
                Debug.LogError("Rigidbody component not found on the instantiated car.");
            }
            Debug.Log("Object instantiated!");
        }
        else
        {
            Debug.LogError("Object to instantiate or spawn point is not assigned.");
        }
    }
}
