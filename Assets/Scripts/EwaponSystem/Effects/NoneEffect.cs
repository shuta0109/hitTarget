using UnityEngine;
using WeaponSystem.Interfaces;

namespace WeaponSystem.Effects
{
    public class NoneEffect : IElementalEffect
    {
        public string GetName() => "None";
        public void ApplyEffect(GameObject target) { }
    }
}
