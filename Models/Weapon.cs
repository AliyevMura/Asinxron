using Aspose.Cells.Drawing.Texts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asinxron.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public int MaxBulletCount { get;  set; }
        public List<Bullet> Bullets { get; set; } = new List<Bullet>();
        public int BulletCount { get;  set; }
        public string BulletType { get;  set; }

        public Weapon(int maxBulletCount, string bulletType)
        {
            MaxBulletCount = maxBulletCount;
            BulletCount = maxBulletCount;
            BulletType = bulletType;
           Bullets = new List<Bullet>();    
        }

        public void Fire()
        {
            if (BulletCount == 0)
            {
                Console.WriteLine("Gulle azalir!");
            }
            else
            {
                Console.WriteLine($"Atew {BulletType} gulle. {BulletCount} gulle qalib.");
            }
        }
    }

    public enum BulletType
    {
        Standard,
        ArmorPiercing,
        Incendiary
    }
    public void PullTrigger()
    {
        if (Bullets.Count == 0)
        {
            Console.WriteLine("Güllə qalmadı!");
            return;
        }

        Console.WriteLine($"Növbəti güllə {Bullets[0].Type}.");
    }

}
