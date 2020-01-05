using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character Modifier", menuName = "Items/Modifiers")]
public class CharacterModifiers : Modifiers
{
    public List<CharacterStatModifier> modifiers = new List<CharacterStatModifier>();

    public override void Initialize(GameObject obj)
    {
        
    }
}

[System.Serializable]
public class CharacterStatModifier : StatModifierBase<CharacterStat>
{

}