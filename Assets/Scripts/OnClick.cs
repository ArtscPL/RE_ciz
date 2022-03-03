using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnClick : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject target;
    public void OnPointerClick(PointerEventData eventData)
    {
        target.gameObject.SetActive(!target.gameObject.activeSelf);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            target.gameObject.SetActive(!target.gameObject.activeSelf);
        }
    }
}
