using UnityEngine;
using WeaponSystem.Interfaces;

namespace WeaponSystem.Effects
{
    public class FireEffect : IElementalEffect
    {
        public string GetName() => "Fire";

        public void ApplyEffect(GameObject target)
        {
            Debug.Log("Fire effect applied!");
        }
    }
}
