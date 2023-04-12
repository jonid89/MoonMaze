using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moonpiece_pickup : MonoBehaviour
{
    public float bounceSpeed = 8;
    public float bounceAmplitude = 0.8f;
    public float rotationSpeed = 90;

    private float StartingHeight;
    private float timeOffset;

    // Start is called before the first frame update
    private void Start()
    {
        StartingHeight = transform.localPosition.y;
        timeOffset = Random.value * Mathf.PI * 2;
    }

    // Update is called once per frame
    void Update()
    {
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
}
