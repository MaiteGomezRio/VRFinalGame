using UnityEngine;

public class LocomotionSwitcher : MonoBehaviour
{
    
    public GameObject teleportationSystem; // El sistema de teleportaci�n
    public OVRPlayerController playerController; // El controlador de movimiento con joystick

    
    public OVRInput.Button toggleButton = OVRInput.Button.One;

    private bool isTeleportActive = false;

    void Start()
    {
        // Desactivar el sistema de teleportaci�n al iniciar
        teleportationSystem.SetActive(false);
        playerController.enabled = true;  // El movimiento loco est� activado por defecto
    }

    void Update()
    {
        
        if (OVRInput.GetDown(toggleButton))
        {
           
            isTeleportActive = !isTeleportActive;

            // Activa/desactiva la teleportaci�n y el movimiento loco seg�n el estado
            teleportationSystem.SetActive(isTeleportActive);
            playerController.enabled = !isTeleportActive;
        }
    }
}

