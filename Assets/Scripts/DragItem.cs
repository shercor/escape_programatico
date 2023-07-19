using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class DragItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    //private RectTransform rectTransform;
    //private Vector2 offset;
    public Image image;
    public TextMeshProUGUI T1,T2,T3;
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
        T1.raycastTarget =false;
        T2.raycastTarget =false;
        T3.raycastTarget =false;
        //up.interactable =false;
        //down.interactable =false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //rectTransform.anchoredPosition = eventData.position + offset;
        //Debug.Log("Dragging");
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // Realiza acciones adicionales al soltar el objeto, si es necesario
        //Debug.Log("End Drag");
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
        T1.raycastTarget =true;
        T2.raycastTarget =true;
        T3.raycastTarget =true;
        //up.interactable =true;
        //down.interactable =true;
    }
}