using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    bool hasPackage;
    float destroyDelay = 0.3f;

    [SerializeField] Color32 hasPackageColor = new(1,1,1,1);
    [SerializeField] Color32 noPackageColor = new (1,1,1,1);

    // Type od SpriteRenderer
    SpriteRenderer spriteRenderer;

    void Start() 
    {
        // We get the component in the start method and storing ot cashing that component in a variable and this variable colled Sprite Renderer, now we can use the sprite renderer wherever we want
        spriteRenderer = GetComponent<SpriteRenderer>();    
    }
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Ouch!");
    }    

    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Package") && !hasPackage) // !hasPackage = false so prevent other packages from being destroyed
        {
            Debug.Log("You picked up a package!");  
            // We put hasPackage = true to prove that we have a package
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject,destroyDelay);
        }
        if(other.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("You delivered a package!");
            // We put hasPackage back to false to prevent deliver the package over and over again
            hasPackage = false;
            spriteRenderer.color = noPackageColor;

         }
    }
}
