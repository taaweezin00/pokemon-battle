using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.pokemons
{
    public class Pokemon
    {
        protected string name;
        protected int HP;
        protected int Attack;
        protected int Defense;
        protected int Speed;
        protected Bitmap _image;

        public Bitmap getImage()
        {
            return _image;
        }
        public string getName() { return this.name; }
        public int getHP() { return this.HP;}
        public int getAttack() { return this.Attack;}
        public  int getDefense() { return this.Defense;}
        public void takeDamage(int damage) { 
            this.HP -= damage;
        }
    }
}
