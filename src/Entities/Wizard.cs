namespace RPG_POO.src.Entities
{
    public class Wizard: Hero {

        public Wizard(string name, int level, string heroType) : base(name, level, heroType) {

        }
        
        public override string Attack() {
            return $"{this.name} lançou magia.";
        }

        public string Attack(int bonus) {
            if (bonus > 6) {
                return $"{this.name} lançou uma magia super efetiva com bônus de {bonus}";
            } else {
                return $"{this.name} lançou uma magia com força fraca com bônus de {bonus}";
            }
        }

    }
}