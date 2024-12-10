using UnityEngine;
using UnityEngine.EventSystems;

public class Documentos : MonoBehaviour
{
    public GameObject popupUI; // Referencia al objeto del menú emergente
    //public bool isMenuOpen = false; // Variable que indica si el menú emergente está abierto

    private void Start()
    {
        HidePopup(); // Oculta el menú emergente al inicio del juego
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("K PRESIONADA");
            TogglePopup(); // Muestra u oculta el menú emergente si se hace clic en este objeto

        }
    }

    private void TogglePopup()
    {
        popupUI.SetActive(!popupUI.activeSelf); // Activa o desactiva el menú emergente
    }

    private void HidePopup()
    {
        popupUI.SetActive(false); // Desactiva el menú emergente
    }
}