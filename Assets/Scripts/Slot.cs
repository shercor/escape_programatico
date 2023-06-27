using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{
    // Start is called before the first frame update
    public void OnDrop(PointerEventData eventData){
        //if (transform.childCount == 0){
            GameObject dropped = eventData.pointerDrag;
            DragItem draggableItem = dropped.GetComponent<DragItem>();
            draggableItem.parentAfterDrag = transform;
        //}
        
    }
}
