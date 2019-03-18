using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    [SerializeField]
    private float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"Horizontal input: {Input.GetAxis("Horizontal")}");
        Debug.Log($"Vertical input: {Input.GetAxis("Vertical")}");

        transform.Translate(Input.GetAxis("Horizontal") * speed *Time.deltaTime, Input.GetAxis("Vertical") * speed *Time.deltaTime, 0);
    }
}
