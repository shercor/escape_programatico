using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class DragItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    //private RectTransform rectTransform;
    //private Vector2 offset;
    public Image image, icon;
    public TextMeshProUGUI T1,T2,T3,T4;
    public Button up, down;
    [HideInInspector] public Transform parentAfterDrag;
    
    private void start(){
        //icon.enabled = false;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1)) // "1" represents the right mouse button
        {
            // Code to execute when right-click is detected
            Debug.Log("Right-click detected!");
            if (this.tag == "doc"){
                Destroy(this.gameObject, 0f);
            }
            
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        //offset = rectTransform.anchoredPosition - eventData.position;
        //Debug.Log("Begin Drag");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.parent.parent);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
        //icon.raycastTarget = false;
        T1.raycastTarget =false;
        T2.raycastTarget =false;
        T3.raycastTarget =false;
        if (this.tag == "arreglo"){
            T4.raycastTarget =false;
        }
        if (this.tag =="doc"){
            icon.raycastTarget =false;
        }
        
        //up.interactable =false;
        //down.interactable =false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //rectTransform.anchoredPosition = eventData.position + offset;
        //Debug.Log("Dragging");
        transform.position = Input.mousePosition;
        if (this.tag == "doc"){
            T1.enabled =false;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        T1.enabled = true;
        Debug.Log(this.transform.parent.name);
        if (transform.parent.CompareTag("tablero")){
            Debug.Log("TABLERO AQUI");
            
        }
        // Realiza acciones adicionales al soltar el objeto, si es necesario
        //Debug.Log("End Drag");
        transform.SetParent(parentAfterDrag);
        Debug.Log(this.transform.parent.tag);
        if (transform.parent.CompareTag("tablero")){
            Debug.Log("TABLERO AQUI");
            //image.enabled = false;
            //image.gameObject.SetActive(false);
            icon.gameObject.SetActive(true);
        }
        image.raycastTarget = true;
        //icon.raycastTarget = true;
        T1.raycastTarget =true;
        T2.raycastTarget =true;
        T3.raycastTarget =true;
        if (this.tag == "arreglo"){
            T4.raycastTarget =true;
        };
        if (this.tag =="doc"){
            icon.raycastTarget =true;
        }
        //up.interactable =true;
        //down.interactable =true;
    }
}