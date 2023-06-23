using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CerrarBoton : MonoBehaviour, IPointerClickHandler
{
    public GameObject popupMenu;

    public void OnPointerClick(PointerEventData eventData)
    {
        // Realiza la acción al hacer clic en el botón de "Cerrar"
        // Puede ser cerrar el menú emergente, desactivar objetos, etc.
        popupMenu.SetActive(false);
    }
}