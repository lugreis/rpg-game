namespace rpg_game.src.Entities
{
    public abstract class Hero
    {
        public string Name;
        public int Level;
        public string HeroType;

        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com a sua espada";
        }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }
    }
} 