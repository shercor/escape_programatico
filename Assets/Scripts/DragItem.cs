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
    [HideInInspector] public Transform parentAfterDrag;

    public void OnBeginDrag(PointerEventData eventData)
    {
        //offset = rectTransform.anchoredPosition - eventData.position;
        Debug.Log("Begin Drag");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.parent.parent);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
        //T1.GetComponent<TextMeshProUGUI>().raycastTarget =false;
        //T2.GetComponent<TextMeshProUGUI>().raycastTarget =false;
        //T3.GetComponent<TextMeshProUGUI>().raycastTarget =false;
        T1.raycastTarget =false;
        T2.raycastTarget =false;
        T3.raycastTarget =false;
        //transform.GetChild(0).raycastTarget = false;


    }

    public void OnDrag(PointerEventData eventData)
    {
        //rectTransform.anchoredPosition = eventData.position + offset;
        Debug.Log("Dragging");
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // Realiza acciones adicionales al soltar el objeto, si es necesario
        Debug.Log("End Drag");
        //Destroy(transform.GetChild(0).gameObject);
        //transform.GetChild(0).transform.SetParent(parentAfterDrag.GetChild(0));
        transform.SetParent(parentAfterDrag);
        //transform.GetChild(0).transform.SetParent(transform);


        //GameObject textoUIObjeto = new GameObject("TextoUI");
       // textoUIObjeto.transform.SetParent(transform); // Establecer el objeto padre
        //Text textoUIComponente = textoUIObjeto.AddComponent<Text>();
        //textoUIComponente.text = "XD";
        //textoUIComponente.transform.position = new Vector3(2,-2,1);

        //transform.GetChild(0).gameObject.SetActive(true);
        image.raycastTarget = true;
        T1.raycastTarget =true;
        T2.raycastTarget =true;
        T3.raycastTarget =true;
    }
}