using UnityEngine;
using UnityEngine.UI;

public class ItemTooltip : MonoBehaviour
{
	[SerializeField] Text ItemNameText;
	[SerializeField] Text ItemTypeText;
	[SerializeField] Text ItemStatsText;
	[SerializeField] Text ItemTitleText;
	

	private void Awake()
	{
		gameObject.SetActive(false);
	}

	public void ShowTooltip(Item item)
	{
		ItemNameText.text = item.ItemName;
		ItemTypeText.text = item.GetItemType();
		ItemStatsText.text = item.GetDescription();
		ItemTitleText.text = item.GetItemTitle();
		gameObject.SetActive(true);
	}

	public void HideTooltip()
	{
		gameObject.SetActive(false);
	}
}
