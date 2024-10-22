
using UnityEngine;
using UnityEngine.UI;

public class PanelInteraction : MonoBehaviour
{
    // Variable para almacenar el estado del panel (si est� activado o no)
    private bool isActive = false;

    // Referencia al componente de Renderer para cambiar el color del panel (si es un objeto 3D)
    private Renderer panelRenderer;

    void Start()
    {
        
        panelRenderer = GetComponent<Renderer>();
        UpdatePanelState(); 
    }

    // M�todo que se llama cuando el jugador interact�a con el panel
    public void Interact()
    {
        isActive = !isActive; // Alterna el estado
        UpdatePanelState(); // Actualiza el estado del panel
    }

    // M�todo para actualizar el estado visual del panel
    void UpdatePanelState()
    {
        if (panelRenderer != null)
        {
            // Cambia el color del panel seg�n el estado
            if (isActive)
            {
                panelRenderer.material.color = Color.green; // Panel activo (color verde)
            }
            else
            {
                panelRenderer.material.color = Color.red; // Panel inactivo (color rojo)
            }
        }
    }
}
