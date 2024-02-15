using SharpDX.MediaFoundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_AnimalRace.Classes
{
    internal abstract class Animal
    {
        protected float speed = 0;
        protected Texture2D texture;
        protected Vector2 position;
        protected Vector2 velocity;
        protected Game1 game;

        public Animal(int start_speed, Vector2 start_position, Game1 _game)
        {
            speed = start_speed;
            position = start_position;
            game = _game;
        }

        abstract public void Update();
        abstract public void move();
        virtual public void reset(int start_line) => position.X = start_line - texture.Width;
        
        virtual public void setSpeed(float speed) => this.speed = speed;
        virtual public void setPosition(Vector2 position) => this.position = position;
        virtual public void setTexture(Texture2D texture) => this.texture = texture;
        virtual public Vector2 getPosition() => position;
        virtual public float getSpeed() => speed;
        virtual public Texture2D getTexture() => texture;
    }
}
