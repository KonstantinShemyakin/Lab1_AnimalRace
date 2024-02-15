
namespace Lab1_AnimalRace.Classes
{
    internal class Rabbit : Animal
    {
        private float hop_distance;
        private float timer = 0;
        private bool is_waiting = true;
        private Vector2 timings;
        private float accel = 0.1f;
        private float y_floor;

        public Rabbit(int hop_distance, int speed, Vector2 position, Game1 _game)
            :base(speed, position, _game)
        {
            this.hop_distance = hop_distance;
            float time = 60f / speed;
            timings = new Vector2(time * 0.99f, time * 0.01f);
            y_floor = position.Y;
        }

        public override void Update()
        {
            if (is_waiting && timer <= 0)
            {
                is_waiting = false;
                timer = timings.X;
                velocity.X = hop_distance / timer;
                velocity.Y = -velocity.X;
            }
            else if(!is_waiting) move();
            
            timer -= 1 / game.getFps();
        }

        public override void move()
        {
            position += velocity;
            velocity.Y -= accel / game.getFps();
            if (po)
        }
    }
}
