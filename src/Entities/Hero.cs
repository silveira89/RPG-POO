namespace RPG_POO.src.Entities
{
    public abstract class Hero
    {
        public string? name { get; set; }
        public int level { get; set; }
        public string? heroType { get; set; }

        public Hero(string name, int level, string heroType) {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        public override string? ToString() {
            return $"{this.name} {this.level} {this.heroType}";
        }

        public virtual string Attack() {
            return $"{this.name} atacou com sua espada.";
        }
    }
}