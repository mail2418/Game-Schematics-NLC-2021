using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDragged : MonoBehaviour,IBeginDragHandler,IEndDragHandler, IDragHandler
{
    Vector3 startPosition;
    Transform StartParent;
    public static GameObject itemBeingDragged;

    private RectTransform rectTransform;
    public CanvasGroup canvasGroup;
    public static Vector3 resetPosition;
    Place_Drag place_Drag;

    bool placed = false;
    private void Awake() 
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        place_Drag = FindObjectOfType<Place_Drag>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        if(!placed)
        {
            canvasGroup.alpha = .6f;
            canvasGroup.blocksRaycasts = false;

            resetPosition = this.transform.localPosition;
            itemBeingDragged = gameObject;
            startPosition = transform.position;
            StartParent = transform.parent;
        }
    }
    private void Update() {
        if(placed)
        {
            rectTransform.sizeDelta = new Vector2(50,50);
            canvasGroup.blocksRaycasts = true;
        }
    }
    public void OnDrag(PointerEventData eventData)
    {
        if(!placed)
            transform.position = Input.mousePosition;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        if(!placed)
        {
            itemBeingDragged = null;

            if(transform.parent != StartParent)
            {
                rectTransform.sizeDelta = new Vector2(50,50);
                canvasGroup.alpha = 1f;
                canvasGroup.blocksRaycasts = true;
                transform.position = startPosition;
                
                if(gameObject.name == "Hati(Clone)")
                {
                    place_Drag.DuplicateObjectHati();
                }
                else if(gameObject.name == "JG(Clone)")
                {
                    place_Drag.DuplicateObjectJG();
                }
                else if(gameObject.name == "KTPT(Clone)")
                {
                    place_Drag.DuplicateObjectKTPT();
                }
                else if(gameObject.name == "SGTG(Clone)")
                {
                    place_Drag.DuplicateObjectSGTG();
                }
                else
                {
                    place_Drag.DuplicateObjectLGKRN();
                }
                placed = true;
            }
            else
            {
                this.transform.localPosition = new Vector3(resetPosition.x,resetPosition.y,resetPosition.z);
                canvasGroup.alpha = 1f;
                canvasGroup.blocksRaycasts = true;
            }
        }
    }
}