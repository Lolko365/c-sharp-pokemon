﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame
{
    class UpWalkingState : IPlayerState
    {
        Player player;
        public IAnimatedSprite Sprite { get; set; }

        public UpWalkingState(Player currentPlayer)
        {
            ISpriteFactory factory = new SpriteFactory();
            Sprite = factory.builder(SpriteFactory.sprites.upWalkingPlayer);
            player = currentPlayer;
        }

        public Rectangle GetBoundingBox(Vector2 location)
        {
            return Sprite.GetBoundingBox(location);
        }

        public void Down()
        {
            player.state = new DownIdleState(player);
        }

        public void Left()
        {
            player.state = new LeftIdleState(player);
        }

        public void Right()
        {
            player.state = new RightIdleState(player);
        }

        public void Up()
        {
        }

        public void Idle()
        {
            player.state = new UpIdleState(player);
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location, Color color)
        {
            Sprite.Draw(spriteBatch, location, color);
        }

        public void Update(GameTime gameTime)
        {
            Sprite.Update(gameTime);
        }
    }
}
