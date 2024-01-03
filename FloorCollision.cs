using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCollision : MonoBehaviour
{
    public GameObject mainCamera;
    public string ParkingLiftName(){
        GameObject currentObject = gameObject;
        currentObject = currentObject.transform.parent.gameObject;
        while (currentObject.transform.parent != null)
        {
            currentObject = currentObject.transform.parent.gameObject;
        }
        return currentObject.name;
    } 
    IEnumerator RotateLift()
    {
        string parkingLiftName = ParkingLiftName();
        GameObject ParkingLift = GameObject.Find(parkingLiftName);
        CollisionHandler CollisionHandlerScript = ParkingLift.GetComponent<CollisionHandler>();   
        yield return new WaitForSeconds(2.5f);
        CollisionHandlerScript.TogglePause();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gate Detected Car"))
        {
            Debug.Log("Car is inside the trigger!");
            string parkingLiftName = ParkingLiftName();
            GameObject ParkingLift = GameObject.Find(parkingLiftName);
            Debug.Log(parkingLiftName);
            if (ParkingLift != null)
            {
                CollisionHandler CollisionHandlerScript = ParkingLift.GetComponent<CollisionHandler>();

                if (CollisionHandlerScript != null)
                {
                    other.transform.SetParent(transform);
                    Rigidbody carRigidbody = other.GetComponent<Rigidbody>();
                    if (carRigidbody != null)
                    {
                        carRigidbody.useGravity=false;
                        carRigidbody.isKinematic=true;
                    }

                    other.tag = "Parked Car";
                    CollisionHandlerScript.TogglePause();
                    StartCoroutine(RotateLift());
                }
                else
                {
                    Debug.LogError("CollisionHandlerScript component not found on the GameObject.");
                }
            }
            else
            {
                Debug.LogError("ParkingLift GameObject with the name 'ObjectWithScriptA' not found.");
            }

        }
    }
}
