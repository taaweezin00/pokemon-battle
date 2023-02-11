using PokemonBattle.pokemons;
using System;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace PokemonBattle
{
    public partial class Form1 : Form
    {
        List<Pokemon> pokemons;
        Pokemon selectedPokemon;
        Pokemon monster;
        public Form1()
        {
            InitializeComponent();

            pokemons= new List<Pokemon>();
            pokemons.Add(new Ivysaur());
            pokemons.Add(new Venusaur());
            pokemons.Add(new Gachop());
            pokemons.Add(new Empoleon());
            pokemons.Add(new Caterpie());

            this.monster = new Caterpie();
            this.pictureBox2.Image = this.monster.getImage();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[0];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            int gg = this.selectedPokemon.getHP();
            //tbHP.Text = gg;
            tbHP.Text = gg.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[1];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            int gg = this.selectedPokemon.getHP();
            //tbHP.Text = gg;
            tbHP.Text = gg.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[4];
            int gg = this.selectedPokemon.getHP();
            //tbHP.Text = gg;
            textBox2.Text = gg.ToString();
            int damage = this.selectedPokemon.getHP() - this.selectedPokemon.getAttack();
            this.textBox1.Text = selectedPokemon.getName();
            //display data
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[2];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            int gg = this.selectedPokemon.getHP();
            //tbHP.Text = gg;
            tbHP.Text = gg.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[3];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            int gg = this.selectedPokemon.getHP();
            //tbHP.Text = gg;
            tbHP.Text = gg.ToString();










        }

        private void button7_Click(object sender, EventArgs e)
        {
            int gg = this.selectedPokemon.getHP();
            //int ez = this.selectedPokemon.getAttack();
            //tbHP.Text = gg.ToString();
            //tbHP.Text = ez.ToString();
            //tbHP.Text = gg - ez 
            int x = int.Parse(textBox2.Text) - this.selectedPokemon.getAttack();

            textBox2.Text = x.ToString();
            if (x <= 0)
            {
                textBox2.Text = "á¾é!";
                MessageBox.Show("¹éÍ¹ä»áÅéÇ");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox2.Text) - this.selectedPokemon.getAttack();

            tbHP.Text = x.ToString();
            if (x <= 0)
            {
                tbHP.Text="á¾é!";
            }
        }
    }
}