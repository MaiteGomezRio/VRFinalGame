using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public Transform controller; 
    public float maxDistance = 10f; // Distancia máxima del raycast

    void Update()
    {
        
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            RaycastHit hit;

            // Lanza un Raycast desde el controlador
            if (Physics.Raycast(controller.position, controller.forward, out hit, maxDistance))
            {
                // Verifica si el objeto golpeado tiene el PanelManager (el panel interactivo)
                PanelInteraction panel = hit.collider.GetComponent<PanelInteraction>();
                if (panel != null)
                {
                    // Cambia el estado del panel (color)
                    panel.Interact();
                }
            }
        }
    }
}
