using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class IsPickedUp : MonoBehaviour
{
    public UnityEvent pickedUp;

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            pickedUp.Invoke();
            Destroy(gameObject);
            SceneManager.LoadScene("EndOfTheLevel");
        }
    }
}
