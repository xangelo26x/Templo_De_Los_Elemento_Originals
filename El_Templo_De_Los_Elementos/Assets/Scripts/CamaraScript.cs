using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraScript : MonoBehaviour
{
    public GameObject Aria;
    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.x = Aria.transform.position.x;
        transform.position = position;
    }
}