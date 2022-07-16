using DioRPG.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DioRPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }


        public override string Attack()
        {
            return this.Name + " lançou magia";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
                return this.Name + " lançou magia com dano super efetivo de " + bonus;
            else
                return this.Name + " lançou magia fraca";


        }
    }
}
