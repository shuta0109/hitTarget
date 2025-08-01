using UnityEngine;
using WeaponSystem.Interfaces;

namespace WeaponSystem.Effects
{
    public class PoisonEffect : IElementalEffect
    {
        public string GetName() => "Poison";

        public void ApplyEffect(GameObject target)
        {
            Debug.Log("Poison effect applied!");
        }
    }
}
