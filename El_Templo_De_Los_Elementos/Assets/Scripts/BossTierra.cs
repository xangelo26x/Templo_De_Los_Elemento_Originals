using UnityEngine;

public class Flotar : MonoBehaviour
{
    public float fuerzaFlotacion = 500f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("No se encontró un componente Rigidbody en el objeto.");
        }
        else
        {
            // Aplicar una fuerza hacia arriba para mantener al personaje flotando
            rb.AddForce(Vector3.up * fuerzaFlotacion);
        }
    }
}
