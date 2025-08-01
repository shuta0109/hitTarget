using UnityEngine;
using WeaponSystem.Interfaces;

namespace WeaponSystem.Effects
{
    public class ThunderEffect : IElementalEffect
    {
        public string GetName() => "Thunder";

        public void ApplyEffect(GameObject target)
        {
            Debug.Log("Thunder effect applied!");
        }
    }
}
