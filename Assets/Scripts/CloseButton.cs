using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CloseButton : MonoBehaviour
{
    public GameObject popupMenu; // Referencia al objeto del menú emergente
    public GameObject popUp;

    private void Start()
    {
        Button closeButton = GetComponent<Button>();
        closeButton.onClick.AddListener(ClosePopup); // Asigna la función ClosePopup al evento de clic del botón
    }

    private void ClosePopup()
    {
        popUp.GetComponent<PopUpMenu>().isMenuOpen = false; //Señala que el menú no está abierto
        popupMenu.SetActive(false); // Desactiva el menú emergente al hacer clic en el botón "Cerrar"
    }
}
