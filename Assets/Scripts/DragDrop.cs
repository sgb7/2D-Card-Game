using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    private bool isDragging = false;
    private bool isOverDropzone = false;
    private GameObject dropzone;
    private Vector2 startPosition;

    void Update()
    {
        if(isDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
    }

    public void StartDrag()
    {
        startPosition = transform.position;
        isDragging = true;
    }

    public void EndDrag()
    {
        isDragging = false;
        if(isOverDropzone)
        {
            transform.SetParent(dropzone.transform, false);
        }
        else
        {
            transform.position = startPosition;
        }
    }
}
