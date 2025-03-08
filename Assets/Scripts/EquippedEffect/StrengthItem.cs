using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class StrengthItem : EquipmentItem.EquippedEffect
{
     public int StrengthModifier;
     public override void Equipped(CharacterData user)
     {
        StatSystem.StatModifier modifier = new StatSystem.StatModifier();
        modifier.ModifierMode = StatSystem.StatModifier.Mode.Absolute;
        modifier.Stats.strength = StrengthModifier;
        user.Stats.AddModifier(modifier);
     
     }
     
     public override void Removed(CharacterData user)
     {
          StatSystem.StatModifier modifier = new StatSystem.StatModifier();
          modifier.ModifierMode = StatSystem.StatModifier.Mode.Absolute;
          modifier.Stats.strength = -StrengthModifier;
          user.Stats.AddModifier(modifier);

     
     }
}
