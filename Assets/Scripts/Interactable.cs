using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float grabDistance = 1.5f;

    public void OnGrab()
    {
        // L�gica para agarrar el objeto
        transform.SetParent(Camera.main.transform);
        transform.localPosition = new Vector3(0, 0, grabDistance);
    }

    public void OnRelease()
    {
        // L�gica para soltar el objeto
        transform.SetParent(null);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            // Ejecutar acci�n al acercarse
        }
    }
}
