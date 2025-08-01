using UnityEngine;
using WeaponSystem.Interfaces;
using WeaponSystem.Bullet;
using WeaponSystem.Gun;
using WeaponSystem.Effects;

namespace WeaponSystem
{
    public class WeaponManager : MonoBehaviour
    {
        private IGun swGun;
        private IGun akmGun;

        void Start()
        {
            // 銃の作成
            swGun = new Gun<IBullet>(6, 1.0f, 1.0f, 2.0f);
            akmGun = new Gun<IBullet>(30, 3.0f, 0.4f, 4.0f);

            // 弾の作成
            IBullet bulletA = new BulletParameter(50, 10, new NoneEffect());
            IBullet bulletB = new BulletParameter(70, 5, new FireEffect());
            IBullet bulletC = new BulletParameter(30, 5, new PoisonEffect());
            IBullet bulletD = new BulletParameter(100, 20, new ThunderEffect());

            // S&Wに弾Aを6発装填
            for (int i = 0; i < 6; i++) ((Gun<IBullet>)swGun).LoadBullet(bulletA);

            // AKMにB→C→D順で装填（各10発）
            for (int i = 0; i < 10; i++)
            {
                ((Gun<IBullet>)akmGun).LoadBullet(bulletB);
                ((Gun<IBullet>)akmGun).LoadBullet(bulletC);
                ((Gun<IBullet>)akmGun).LoadBullet(bulletD);
            }

            // テスト発射
            swGun.Fire(); // 弾A発射
            akmGun.Fire(); // 弾B発射
        }
    }
}
