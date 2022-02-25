using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIItem : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Item item;
    private Image spritesItem;
    private UIItem selectedItem;
    private Tooltip tooltip;
    private void Awake()
    {
        spritesItem = GetComponent<Image>();
        UpdateItem(null);
        selectedItem = GameObject.Find("SelectedItem").GetComponent<UIItem>();
        tooltip = GameObject.Find("Tooltip").GetComponent<Tooltip>();
    }
    public void UpdateItem(Item item)
    {
        this.item = item;
        if (this.item != null)
        {
            spritesItem.color = Color.white;
            spritesItem.sprite = this.item.icon;
        }
        else
        {
            spritesItem.color = Color.clear;
        }
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (this.item != null)
        {
            if (selectedItem.item != null)
            {
                Item clone = new Item(selectedItem.item);
                selectedItem.UpdateItem(this.item);
                UpdateItem(clone);
            }
            else
            {
                selectedItem.UpdateItem(this.item);
                UpdateItem(null);
            }
        }
        else if (selectedItem.item != null)
        {
            UpdateItem(selectedItem.item);
            selectedItem.UpdateItem(null);
        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        if(this.item != null)
        {
            StartCoroutine(DelayAction());
            tooltip.GenerateTooltip(this.item);
        }
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        tooltip.gameObject.SetActive(false);
    }
    public IEnumerator DelayAction()
    {
        yield return new WaitForSeconds(5f);
    }
}
