using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    public delegate void DragEndedDelegate(Draggable draggableObject);
    public DragEndedDelegate dragEndedCallback;

    private bool isDragged = false;
    private Vector3 mouseDragStartPosition;
    private Vector3 spriteStartDragPosition;
    private void OnMouseDown()
    {
        isDragged = true;
        mouseDragStartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spriteStartDragPosition = transform.localPosition;      
    }
    void OnMouseDrag()
    {
        if(isDragged)
        {
            transform.localPosition = spriteStartDragPosition + (Camera.main.ScreenToWorldPoint(Input.mousePosition) - mouseDragStartPosition);
        }        
    }
    void OnMouseUp()
    {
        isDragged = false;
        dragEndedCallback(this);
    }       
}
