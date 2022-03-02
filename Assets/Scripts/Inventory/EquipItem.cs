using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kryz.CharacterStats;

public enum EquipmentType
{
   Helmet,
   Armor,
   Weapon1,
   Accessory1,
   Accessory2,
}
[CreateAssetMenu]
public class EquipItem : Item
{
    public int HP_Bonus;
    public int Def_Bonus;
    public int Eva_Bonus;
    public int Res_Bonus;
    [Space]
    public float HP_Percent_Bonus;
    public float Def_Percent_Bonus;
    public float Eva_Percent_Bonus;
    public float Res_Percent_Bonus;
    [Space]
    public EquipmentType EquipmentType;

    public void Equip(Character c)
    {
        if (HP_Bonus != 0)
            c.Health.AddModifier(new StatModifier(HP_Bonus, StatModType.Flat, this));
        if (Def_Bonus != 0)
            c.Defense.AddModifier(new StatModifier(Def_Bonus, StatModType.Flat, this));
        if (Eva_Bonus != 0)
            c.Evasion.AddModifier(new StatModifier(Eva_Bonus, StatModType.Flat, this));
        if (Res_Bonus != 0)
            c.Ressistant.AddModifier(new StatModifier (Res_Bonus, StatModType.Flat, this));

        if (HP_Percent_Bonus != 0)
            c.Health.AddModifier(new StatModifier(HP_Percent_Bonus, StatModType.PercentMult, this));
        if (Def_Percent_Bonus != 0)
            c.Defense.AddModifier(new StatModifier(Def_Percent_Bonus, StatModType.PercentMult, this));
        if (Eva_Percent_Bonus != 0)
            c.Evasion.AddModifier(new StatModifier(Eva_Percent_Bonus, StatModType.PercentMult, this));
        if (Res_Percent_Bonus != 0)
            c.Ressistant.AddModifier(new StatModifier(Res_Percent_Bonus, StatModType.PercentMult, this));
    }
    public void Unequip(Character c)
    {
        c.Health.RemoveAllModifiersFromSource(this);
        c.Defense.RemoveAllModifiersFromSource(this);
        c.Evasion.RemoveAllModifiersFromSource(this);
        c.Ressistant.RemoveAllModifiersFromSource(this);
    }
}
