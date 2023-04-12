using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pick_up : MonoBehaviour
{
    public UnityEvent pickedUp;


    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            pickedUp.Invoke();
            Destroy(gameObject);
        }
    }
}
