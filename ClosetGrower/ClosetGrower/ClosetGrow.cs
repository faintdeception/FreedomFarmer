using System;
using ClosetGrower.GameObjects.Pots;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ClosetGrower.GameObjects.Tools.Seeds;
using ClosetGrower.GameObjects.Mediums;
using ClosetGrower.GameObjects.Tools.Mediums;

namespace ClosetGrower
{
    public delegate void DayIncrimentedEventHandler(object sender, EventArgs e);

    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class ClosetGrow : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        int currentDay;

        // An event that clients can use to be notified whenever the
        // elements of the list change.
        public event DayIncrimentedEventHandler DayIncrimented;

        // Invoke the Changed event; called whenever list changes
        protected virtual void OnDayIncrimented(EventArgs e)
        {
            if (DayIncrimented != null)
                DayIncrimented(this, e);
        }

        public ClosetGrow()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            // Frame rate is 30 fps by default for Windows Phone.
            TargetElapsedTime = TimeSpan.FromTicks(333333);

            // Extend battery life under lock.
            InactiveSleepTime = TimeSpan.FromSeconds(1);
        }



        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //Save and load the actual day here.
            this.currentDay = 1;

            ClayPot myClayPot = new ClayPot(this);
            PHBalancedSoilTool mySoil = new PHBalancedSoilTool(this);

            WhiteWidowSeedTool myWhiteWidowSeedTool = new WhiteWidowSeedTool(this);

            mySoil.Use(myClayPot);

            myWhiteWidowSeedTool.Use(myClayPot);

            


            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            this.IncrimentDay();

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }

        public void IncrimentDay()
        {
            this.currentDay++;
            OnDayIncrimented(EventArgs.Empty);
        }
    }
}
