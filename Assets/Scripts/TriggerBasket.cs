using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBasket : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D activator) {
        //cameraTransform.position = new Vector3( 162f, -46f, -10f );


        //Destroy(GameObject.Find("Platform5"));
        Destroy(GameObject.Find("PlatformBasket"));

    }
}