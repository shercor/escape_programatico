using UnityEngine;

public class PopupMenuManager : MonoBehaviour
{
    public GameObject popupMenuPrefab;
    private GameObject currentMenu;

    private void OnMouseDown()
    {
        // Crear y activar el menú emergente al hacer clic en el objeto
        currentMenu = Instantiate(popupMenuPrefab, transform.position, Quaternion.identity);
        this.GetComponent<Popup>().OpenMenu();
    }

    public void CloseMenu()
    {
        // Cerrar el menú emergente al presionar el botón de cierre
        Destroy(currentMenu);
    }
}
