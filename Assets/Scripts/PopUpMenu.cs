using UnityEngine;
using UnityEngine.EventSystems;

public class PopUpMenu : MonoBehaviour
{
public GameObject popupUI; // Referencia al objeto del menú emergente
public bool isMenuOpen = false; // Variable que indica si el menú emergente está abierto

    private void Start()
    {
        HidePopup(); // Oculta el menú emergente al inicio del juego
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                TogglePopup(); // Muestra u oculta el menú emergente si se hace clic en este objeto
            }
        }
    }

    private void TogglePopup()
    {
        popupUI.SetActive(!popupUI.activeSelf); // Activa o desactiva el menú emergente
        //isMenuOpen = true;
    }

    private void HidePopup()
    {
        popupUI.SetActive(false); // Desactiva el menú emergente
        //isMenuOpen = false;
    }
}