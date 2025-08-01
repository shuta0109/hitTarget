namespace WeaponSystem.Interfaces
{
    public interface IGun
    {
        void Fire();
        void Reload();
        bool CanFire();
    }
}
