using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class OpeningTheMenu : MonoBehaviour
{
    public bool IsPickedUp = false;

    public float bounceSpeed = 8;
    public float bounceAmplitude = 0.8f;
    public float rotationSpeed = 90;

    private float StartingHeight;
    private float timeOffset;



    // Start is called before the first frame update
    void Start()
    {
        StartingHeight = transform.localPosition.y;
        timeOffset = Random.value * Mathf.PI * 2;
    }
  
    // Update is called once per frame
    void Update()
    {
        if (IsPickedUp)
        {
            Debug.Log("IsPickedUp");
            SceneManager.LoadScene("EndOfTheLevel");
        }

        // Bounce animation
        float finalHeight = StartingHeight + Mathf.Sin(Time.time * bounceSpeed + timeOffset) * bounceAmplitude;
        var position = transform.localPosition;
        position.y = finalHeight;
        transform.localPosition = position;

        //Spin
        Vector3 rotation = transform.localRotation.eulerAngles;
        rotation.y += rotationSpeed * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(rotation.x, rotation.y, rotation.z);
    }
    public void OnPickedUp()
    {
        IsPickedUp = true;
    }
}
