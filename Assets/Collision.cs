using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    bool hasPackage;
    float destroyDelay = 0.3f;
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Ouch!");
    }    

    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Package") && !hasPackage) // !hasPackage for Destroy & !hasPackage = false
        {
            Debug.Log("You picked up a package!");  
            // We put hasPackage = true to prove that we have a package
            hasPackage = true;
            Destroy(other.gameObject,destroyDelay);
        }
        if(other.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("You delivered a package!");
            // We put hasPackage back to false to prevent deliver the package over and over again
            hasPackage = false;
         }
    }
}
