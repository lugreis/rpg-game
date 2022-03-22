namespace rpg_game.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }

        public override string Attack()
        {
           return this.Name + " Lançou magia";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + " Lançou super magia com bônus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou magia fraca com bônus de " + Bonus;
            }
        }
    }
}