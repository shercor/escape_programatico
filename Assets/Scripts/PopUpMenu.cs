using UnityEngine;
using UnityEngine.EventSystems;

public class PopUpMenu : MonoBehaviour
{
    public GameObject popupUI; // Referencia al objeto del menú emergente
    public Texture2D cursorTexture;
    float distanceToPlayer;
    //public bool isMenuOpen = false; // Variable que indica si el menú emergente está abierto

    private void Start()
    {
        HidePopup(); // Oculta el menú emergente al inicio del juego
    }

    private void Update()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        distanceToPlayer = Vector3.Distance(transform.position, playerObject.transform.position);
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject() && distanceToPlayer < 2.5f)
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
    }

    private void HidePopup()
    {
        popupUI.SetActive(false); // Desactiva el menú emergente
    }

    private void OnMouseEnter()
    {
        if (!EventSystem.current.IsPointerOverGameObject() && distanceToPlayer < 2.5f){
            Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
        }
    }

    // Restaura el cursor cuando el ratón sale del objeto
    private void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
}