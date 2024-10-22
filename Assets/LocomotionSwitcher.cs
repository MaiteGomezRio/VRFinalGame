using UnityEngine;

public class LocomotionSwitcher : MonoBehaviour
{
    
    public GameObject teleportationSystem; // El sistema de teleportación
    public OVRPlayerController playerController; // El controlador de movimiento con joystick

    
    public OVRInput.Button toggleButton = OVRInput.Button.One;

    private bool isTeleportActive = false;

    void Start()
    {
        // Desactivar el sistema de teleportación al iniciar
        teleportationSystem.SetActive(false);
        playerController.enabled = true;  // El movimiento loco está activado por defecto
    }

    void Update()
    {
        
        if (OVRInput.GetDown(toggleButton))
        {
           
            isTeleportActive = !isTeleportActive;

            // Activa/desactiva la teleportación y el movimiento loco según el estado
            teleportationSystem.SetActive(isTeleportActive);
            playerController.enabled = !isTeleportActive;
        }
    }
}

