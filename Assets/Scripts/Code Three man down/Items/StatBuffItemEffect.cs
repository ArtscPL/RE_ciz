using System.Collections;
using UnityEngine;
using Kryz.CharacterStats;

[CreateAssetMenu(menuName = "Item Effects/Stat Buff")]
public class StatBuffItemEffect : UsableItemEffect
{
	public int DefBuff;
	public int ResBuff;
	public int EvaBuff;
	public int Buff;
	public float Duration;

	public override void ExecuteEffect(UsableItem parentItem, Character character)
	{
		if (DefBuff != 0)
		{
			StatModifier statModifier = new StatModifier(DefBuff, StatModType.Flat, parentItem);
			character.Defense.AddModifier(statModifier);
			Buff = DefBuff;
		}
		if (ResBuff != 0)
		{
			StatModifier statModifier = new StatModifier(ResBuff, StatModType.Flat, parentItem);
			character.Resistance.AddModifier(statModifier);
			Buff = ResBuff;
		}
		if (EvaBuff != 0)
		{
			StatModifier statModifier = new StatModifier(EvaBuff, StatModType.Flat, parentItem);
			character.Evasion.AddModifier(statModifier);
			Buff = EvaBuff;
		}

		character.UpdateStatValues();
		//character.StartCoroutine(RemoveBuff(character, statModifier, Duration));
	}

	public override string GetDescription()
	{
		return "Grants " + Buff + " for " + Duration + " turn.";
	}

	private static IEnumerator RemoveBuff(Character character, StatModifier statModifier, float duration)
	{
		yield return new WaitForSeconds(duration);
		character.Defense.RemoveModifier(statModifier);
		character.UpdateStatValues();
	}
}
