using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        playerController controller = other.GetComponent<playerController >();

        if (controller != null)
        
            controller.ChangeHealth(-1);
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
