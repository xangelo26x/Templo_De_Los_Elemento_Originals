using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piezas : MonoBehaviour
{
    private bool Drag;
    private Vector3 PocisionCorrecta;
    private Vector3 offset;
    public float Distance;
    void Start()
    {
        PocisionCorrecta = transform.position;
        transform.position = new Vector3 (UnityEngine.Random.Range(7f,9f), UnityEngine.Random.Range(-2f,2f),transform.position.z);

    }
    private void OnMouseDown()
    {
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
        Drag = true;
    }
    private void OnMouseUp()
    {
        Drag = false;
    }
    void Update()
    {
        if (Drag)
        {
            Vector3 cursorScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
            Vector3 cursorWorldPoint = Camera.main.ScreenToWorldPoint(cursorScreenPoint);
            transform.position = cursorWorldPoint + offset;
        }
        if (Vector3.Distance(PocisionCorrecta, transform.position)<Distance)
        {
            if(!Drag) 
            { 
                transform.position = PocisionCorrecta;
            }
        }

    }
}
