namespace WeaponSystem.Interfaces
{
    public interface IBullet
    {
        int GetPower();
        int GetPenetration();
        IElementalEffect GetEffect();
    }
}
