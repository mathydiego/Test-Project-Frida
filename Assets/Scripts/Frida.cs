using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frida : MonoBehaviour
{
    [SerializeField] string message;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Frida " + message);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
