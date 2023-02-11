using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.pokemons
{
    internal class Empoleon : Pokemon
    {
        public Empoleon() {
            this.name = "Empoleon";
            Random random = new Random();
            //random number between >= 200 and <295
            this.HP = random.Next(230,324);
            this._image = Properties.Resources._004;
            this.Attack = random.Next(116, 245);
            this.Defense = random.Next(117, 247);
        }

    }
}
