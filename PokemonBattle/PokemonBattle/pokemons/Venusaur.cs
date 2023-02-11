using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.pokemons
{
    public class Venusaur : Pokemon
    {
        public Venusaur() {
            
            this.name = "Venusaur";
            Random random = new Random();
            //random number between >= 200 and <295
            this.HP = random.Next(270,364);
            this._image = Properties.Resources._003;
        }       
    }
}
