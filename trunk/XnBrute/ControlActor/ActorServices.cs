using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;


namespace XnBrute
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    /// 
    enum statusactor  {stand=0,dead,fight}
    public class ActorServices : Microsoft.Xna.Framework.DrawableGameComponent,IActorServices
    {
        public ActorServices(Game game)
            : base(game)
        {
            // TODO: Construct any child components here
            spriteBatch = new SpriteBatch(game.GraphicsDevice);
        }

        SpriteBatch spriteBatch;
        Texture2D actor;
        int maxFrame;
        Vector2 position;
        Vector2 size;
        statusactor statusActor;

        void IActorServices.createActor(Texture2D texture, Vector2 size, Vector2 position, int maxframe)
        {
            this.actor = texture;
            this.maxFrame = maxframe;
            this.size = size;
            this.position = position;
            statusActor = statusactor.stand;
        }

        void IActorServices.standActor()
        {
            statusActor = statusactor.stand;
        }

        void IActorServices.deadActor()
        {
            statusActor = statusactor.dead;
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            // TODO: Add your initialization code here

            base.Initialize();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        float time=0;
        int startPointX;
        int frameAt = 0;
        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here
            time += (float)gameTime.ElapsedGameTime.Milliseconds;
            if (time > 200) {
               startPointX = (int)this.size.X * frameAt;
               if (frameAt == maxFrame) {
                   frameAt = 0;
               }
                time = 0;
                frameAt++;
            }
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {


            spriteBatch.Begin();
            if (statusactor.stand == statusActor)
            {
                spriteBatch.Draw(this.actor, new Rectangle((int)this.position.X, (int)this.position.Y, (int)this.size.X, (int)this.size.Y),
                                 new Rectangle(startPointX, 0, (int)this.size.X, (int)this.size.Y), Color.White);
            }
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}