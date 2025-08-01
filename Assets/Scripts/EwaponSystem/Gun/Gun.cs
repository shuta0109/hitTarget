using System.Collections.Generic;
using UnityEngine;
using WeaponSystem.Interfaces;

namespace WeaponSystem.Gun
{
    public class Gun<TBullet> : IGun where TBullet : IBullet
    {
        private int magazineCapacity;
        private float bulletSpeed;
        private float fireInterval;
        private float reloadTime;

        private Queue<TBullet> magazine = new();
        private float lastFireTime = -999f;

        public Gun(int capacity, float speed, float interval, float reload)
        {
            magazineCapacity = capacity;
            bulletSpeed = speed;
            fireInterval = interval;
            reloadTime = reload;
        }

        public void LoadBullet(TBullet bullet)
        {
            if (magazine.Count < magazineCapacity)
                magazine.Enqueue(bullet);
        }

        public bool CanFire()
        {
            return Time.time - lastFireTime >= fireInterval && magazine.Count > 0;
        }

        public void Fire()
        {
            if (!CanFire()) return;

            TBullet bullet = magazine.Dequeue();
            Debug.Log($"Fired! Power: {bullet.GetPower()}, Speed: {bulletSpeed}, Effect: {bullet.GetEffect().GetName()}");

            lastFireTime = Time.time;
        }

        public void Reload()
        {
            Debug.Log($"Reloading... takes {reloadTime} seconds.");
        }
    }
}
