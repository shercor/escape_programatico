using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class DragMochilaItem: MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    //private RectTransform rectTransform;
    //private Vector2 offset;
    public Image image, icon;
    public TextMeshProUGUI T1,T2,T3,T4;
    public Button up, down;
    [HideInInspector] public Transform parentAfterDrag;

    public void OnBeginDrag(PointerEventData eventData)
    {
        //offset = rectTransform.anchoredPosition - eventData.position;
        //Debug.Log("Begin Drag");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.parent.parent);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
        icon.raycastTarget = false;
        T1.raycastTarget =false;
        T2.raycastTarget =false;
        T3.raycastTarget =false;
        if (this.tag == "arreglo"){
            T4.raycastTarget =false;
        }
        
        //up.interactable =false;
        //down.interactable =false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //rectTransform.anchoredPosition = eventData.position + offset;
        //Debug.Log("Dragging");
        transform.position = Input.mousePosition;
        T1.enabled = false;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // Realiza acciones adicionales al soltar el objeto, si es necesario
        //Debug.Log("End Drag");
        T1.enabled = true;
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
        icon.raycastTarget = true;
        T1.raycastTarget =true;
        T2.raycastTarget =true;
        T3.raycastTarget =true;
        if (this.tag == "arreglo"){
            T4.raycastTarget =true;
        };
        //up.interactable =true;
        //down.interactable =true;
    }
}