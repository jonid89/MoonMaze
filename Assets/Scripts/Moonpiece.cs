using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moonpiece : MonoBehaviour
{
    public float bounceSpeed = 8;
    public float bounceAmplitude = 0.8f;
    public float rotationSpeed = 90;
    private float startingHeight;
    private float timeOffset;

    private void Start()
    {
        startingHeight = transform.localPosition.y;
        timeOffset = Random.value * Mathf.PI * 2;
    }

    void Update()
    {
        // Bounce animation
        float finalHeight = startingHeight + Mathf.Sin(Time.time * bounceSpeed + timeOffset) * bounceAmplitude;
        var position = transform.localPosition;
        position.y = finalHeight;
        transform.localPosition = position;

        //Spin
        Vector3 rotation = transform.localRotation.eulerAngles;
        rotation.y += rotationSpeed * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(rotation.x, rotation.y, rotation.z);
    }
}
