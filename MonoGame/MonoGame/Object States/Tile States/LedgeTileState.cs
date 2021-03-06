﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame
{
    class LedgeTileState : ILedgeState
    {
        IAnimatedSprite sprite;
        ISpriteFactory factory;

        public LedgeTileState(SpriteFactory.sprites sprite)
        {
            factory = new SpriteFactory();
            this.sprite = factory.builder(sprite);
        }

        public Rectangle GetBoundingBox(Vector2 position)
        {
            return sprite.GetBoundingBox(position);
        }
        
        public void Update(GameTime gameTime)
        {
            sprite.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location, Color color)
        {
            sprite.Draw(spriteBatch, location, color);
        }
    }
}
