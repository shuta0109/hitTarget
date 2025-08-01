using UnityEngine;

namespace WeaponSystem.Interfaces
{
    public interface IElementalEffect
    {
        string GetName();
        void ApplyEffect(GameObject target);
    }
}
