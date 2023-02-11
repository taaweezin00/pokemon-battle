using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.pokemons
{
    internal class Caterpie : Pokemon
    {
        public Caterpie()
        {
            this.name = "Caterpie";
            Random random = new Random();
            //random number between >= 200 and <295
            this.HP = random.Next(200, 294);
            this._image = Properties.Resources._010;
            this.Attack = random.Next(85, 174);
            this.Defense = random.Next(67, 185);
        }
    }
}
