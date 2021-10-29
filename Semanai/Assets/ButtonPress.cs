using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonPress : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 movement;

    private void Update()
    {
        if (ispressed)
        {
            player.localPosition += movement * Time.deltaTime;
        }
    }

    bool ispressed = false;
    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
    }
}
