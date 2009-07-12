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
using XnBrute.Visualization;
using XnBrute.Data;

namespace XnBrute
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        IActorServices IActors;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

           
        }
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here


            ActorServices actorS = new ActorServices(this);
            Services.AddService(typeof(IActorServices), actorS);
            Components.Add(actorS);

            IActors = (IActorServices)Services.GetService(typeof(IActorServices));
            Texture2D rockman = Content.Load<Texture2D>(@"monster/rockman");
            IActors.createActor(rockman, new Vector2(24, 30), new Vector2(100, 500), 2);
            base.Initialize();
        }

        FightingLogDisplayer logDisplay;
        DrawingContext drawContext;

        protected override void LoadContent()
        {
            drawContext = new DrawingContext();
            drawContext.graphicsDevice = GraphicsDevice;
            drawContext.contentManager = Content;
            drawContext.spriteBatch = new SpriteBatch(GraphicsDevice);
            drawContext.font1 = Content.Load<SpriteFont>("font1");

            // สรัาง log
            FightingLog testLog1 = new FightingLog();
            testLog1.fightingSteps.Enqueue(new FightingLogStep());
            testLog1.fightingSteps.Enqueue(new FightingLogStep());
            FightingLogStep s1 = new FightingLogStep();
            s1.subSteps.Enqueue(new FightingLogStep());
            s1.subSteps.Enqueue(new FightingLogStep());
            testLog1.fightingSteps.Enqueue(s1);
            testLog1.fightingSteps.Enqueue(new FightingLogStep());
            
            // สร้าง log displayer
            logDisplay = new FightingLogDisplayer(testLog1, drawContext);
            logDisplay.Play();



           

        }

        protected override void Update(GameTime gameTime)
        {
            logDisplay.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            logDisplay.Draw(gameTime);
            IActors.standActor();
            base.Draw(gameTime);
        }
    }
}
