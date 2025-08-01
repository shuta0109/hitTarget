using WeaponSystem.Interfaces;

namespace WeaponSystem.Bullet
{
    public class BulletParameter : IBullet
    {
        private int power;
        private int penetration;
        private IElementalEffect effect;

        public BulletParameter(int power, int penetration, IElementalEffect effect)
        {
            this.power = power;
            this.penetration = penetration;
            this.effect = effect;
        }

        public int GetPower() => power;
        public int GetPenetration() => penetration;
        public IElementalEffect GetEffect() => effect;
    }
}
