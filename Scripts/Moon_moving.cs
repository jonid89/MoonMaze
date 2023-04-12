using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon_moving : MonoBehaviour
{
    public float rotX;
    public float rotY;
    public float rotZ;
    public float rotTime = 5;
    public bool pickUpPiece = false;
    private Transform tr;


    // Start is called before the first frame update
    void Start()
    {
        tr = gameObject.transform;
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (pickUpPiece)
        {
            rotX += rotTime * Time.deltaTime;
            transform.rotation = Quaternion.Euler(rotX, rotY, rotZ);

            Debug.Log(rotX);
            if(rotX >= 270)
            {
                gameObject.transform.rotation = tr.rotation;
                rotX = 0;
                pickUpPiece = false;

            }
           


        }
      

    }
    public void OnPickedUp()
    {

        Debug.Log("Hello");
        pickUpPiece = true;
    }
}