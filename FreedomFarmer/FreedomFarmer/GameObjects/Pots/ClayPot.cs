using FreedomFarmer.GameObjects.Pots;
using Microsoft.Xna.Framework;
using System;
using Microsoft.Xna.Framework.Graphics;

namespace FreedomFarmer.GameObjects.Pots
{
    /// <summary>
    /// Clay Pots absorb a litte bit of moisture out of the grow medium every day, and then evaporate it into the air.
    /// </summary>
    class ClayPot : BasePot
    {
       

        /// <summary>
        /// Position in world space of the bottom center of this pot.
        /// </summary>
        public Vector2 Position
        {
            get { return position; }
        }
        Vector2 position;

        private Rectangle localBounds;
        /// <summary>
        /// Gets a rectangle which bounds this enemy in world space.
        /// </summary>
        public Rectangle BoundingRectangle
        {
            get
            {
                int left = (int)Math.Round(Position.X - sprite.Origin.X) + localBounds.X;
                int top = (int)Math.Round(Position.Y - sprite.Origin.Y) + localBounds.Y;

                return new Rectangle(left, top, localBounds.Width, localBounds.Height);
            }
        }

        // Animations
        private Animation idleAnimation;
        private AnimationPlayer sprite;

        //const double MOISTUREABSORBTIONRATE = .005;

        public ClayPot(Game game, Vector2 start)
            : base(game, start)
        {
            this.MoistureAbsorbtionRate = 0.005;    
        }

        /// <summary>
        /// Loads a particular enemy sprite sheet and sounds.
        /// </summary>
        public void LoadContent(string spriteSet)
        {
            // Load animations.
            spriteSet = "Sprites/" + spriteSet + "/";
            idleAnimation = new Animation(Game.Content.Load<Texture2D>(spriteSet + "Idle"), 0.15f, true);
            sprite.PlayAnimation(idleAnimation);

            // Calculate bounds within texture size.
            int width = (int)(idleAnimation.FrameWidth * 0.35);
            int left = (idleAnimation.FrameWidth - width) / 2;
            int height = (int)(idleAnimation.FrameWidth * 0.7);
            int top = idleAnimation.FrameHeight - height;
            localBounds = new Rectangle(left, top, width, height);
        }
       
    }
}
