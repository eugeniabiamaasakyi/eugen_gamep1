using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eugenia_Game : MonoBehaviour
{
public float moveSpeed = 3.0f;
public float rotationSpeed = 90.0f;
public float scaleSpeed = 0.5f;
public float maxScale = 1.0f;

private Vector3 initialScale;

    // Start is called before the first frame update
    void Start()
    {
        initialScale = transform.localScale;

    }

    // Update is called once per frame
    void Update()
    { //Translation shows the cube movement
        Vector3 translation = new Vector3 (1, 0, 0)*moveSpeed*Time.deltaTime;
        transform.Translate(translation);
        
        // Rotation methods
        Vector3 rotation = new Vector3(0, rotationSpeed *Time.deltaTime, 0);
        transform.Rotate(rotation);

// Scale shows the increase of the cube
transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;

    }
}
