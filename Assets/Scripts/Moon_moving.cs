using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon_moving : MonoBehaviour
{
    public float maxRotX = 220;
    public float rotTime = 5;
    public bool pickUpPiece = false;
    private Transform tr;
    private float rotX;

    void Start()
    {
        tr = gameObject.transform;
    }

    void FixedUpdate()
    {
        if (pickUpPiece)
        {
            rotX += rotTime * Time.deltaTime;
            transform.rotation = Quaternion.Euler(rotX, 0, 0);

            if(rotX >= maxRotX)
            {
                gameObject.transform.rotation = tr.rotation;
                rotX = 0;
                pickUpPiece = false;

            }
        }
    }

    public void OnPickedUp()
    {
        pickUpPiece = true;
    }
}