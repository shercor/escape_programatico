using UnityEngine;
using UnityEngine.EventSystems;

public class Popup : MonoBehaviour
{
    //public GameObject menuPanel;
    private bool isMenuOpen = false;
    private EventSystem eventSystem;
    private GameObject previousSelectedObject;
    //

    private void Start()
    {
        eventSystem = FindObjectOfType<EventSystem>();
        eventSystem = EventSystem.current;
        OpenMenu();
    }

    private void Update()
    {
        Debug.Log("Está el sistema de eventos activado?" + eventSystem.enabled);
        Debug.Log("Está el menú abierto?" + isMenuOpen);
        if (isMenuOpen && Input.GetMouseButtonDown(0))
        {
            // Verificar si el clic se realiza dentro del menú emergente
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                // Cerrar el menú si se hace clic fuera del menú emergente
                //CloseMenu();
            }
        }
    }

    public void OpenMenu()
    {

    }

    public void CloseMenu()
    {

    }
}
