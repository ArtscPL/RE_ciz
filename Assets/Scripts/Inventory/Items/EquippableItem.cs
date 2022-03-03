using UnityEngine;
using Kryz.CharacterStats;

public enum EquipmentType
{
	Helmet,
	Armor,
	Weapon,
	Accessory1,
	Accessory2,
}

[CreateAssetMenu(menuName = "Items/Equippable Item")]
public class EquippableItem : Item
{
	public int HP_Bonus;
	public int Def_Bonus;
	public int Eva_Bonus;
	public int Res_Bonus;
	[Space]
	public float HP_PercentBonus;
	public float Def_PercentBonus;
	public float Eva_PercentBonus;
	public float Res_PercentBonus;
	[Space]
	public EquipmentType EquipmentType;

	public override Item GetCopy()
	{
		return Instantiate(this);
	}

	public override void Destroy()
	{
		Destroy(this);
	}

	public void Equip(Character c)
	{
		if (HP_Bonus != 0)
			c.Health.AddModifier(new StatModifier(HP_Bonus, StatModType.Flat, this));
		if (Def_Bonus != 0)
			c.Defense.AddModifier(new StatModifier(Def_Bonus, StatModType.Flat, this));
		if (Eva_Bonus != 0)
			c.Evasion.AddModifier(new StatModifier(Eva_Bonus, StatModType.Flat, this));
		if (Res_Bonus != 0)
			c.Resistance.AddModifier(new StatModifier(Res_Bonus, StatModType.Flat, this));

		if (HP_PercentBonus != 0)
			c.Health.AddModifier(new StatModifier(HP_PercentBonus, StatModType.PercentMult, this));
		if (Def_PercentBonus != 0)
			c.Defense.AddModifier(new StatModifier(Def_PercentBonus, StatModType.PercentMult, this));
		if (Eva_PercentBonus != 0)
			c.Evasion.AddModifier(new StatModifier(Eva_PercentBonus, StatModType.PercentMult, this));
		if (Res_PercentBonus != 0)
			c.Resistance.AddModifier(new StatModifier(Res_PercentBonus, StatModType.PercentMult, this));
	}

	public void Unequip(Character c)
	{
		c.Health.RemoveAllModifiersFromSource(this);
		c.Defense.RemoveAllModifiersFromSource(this);
		c.Evasion.RemoveAllModifiersFromSource(this);
		c.Resistance.RemoveAllModifiersFromSource(this);
	}

	public override string GetItemType()
	{
		return EquipmentType.ToString();
	}

	public override string GetDescription()
	{
		sb.Length = 0;
		AddStat(HP_Bonus, "Health");
		AddStat(Def_Bonus, "Defense");
		AddStat(Eva_Bonus, "Evasion");
		AddStat(Res_Bonus, "Resistance");

		AddStat(HP_PercentBonus, "Health", isPercent: true);
		AddStat(Def_PercentBonus, "Defense", isPercent: true);
		AddStat(Eva_PercentBonus, "Evasion", isPercent: true);
		AddStat(Res_PercentBonus, "Resistance", isPercent: true);

		return sb.ToString();
	}

	private void AddStat(float value, string statName, bool isPercent = false)
	{
		if (value != 0)
		{
			if (sb.Length > 0)
				sb.AppendLine();

			if (value > 0)
				sb.Append("+");

			if (isPercent) {
				sb.Append(value * 100);
				sb.Append("% ");
			} else {
				sb.Append(value);
				sb.Append(" ");
			}
			sb.Append(statName);
		}
	}
}
