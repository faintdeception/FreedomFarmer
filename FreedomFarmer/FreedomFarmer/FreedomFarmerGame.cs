using System;
using FreedomFarmer.GameObjects.Pots;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using FreedomFarmer.GameObjects.Tools.Seeds;
using FreedomFarmer.GameObjects.Mediums;
using FreedomFarmer.GameObjects.Tools.Mediums;
using FreedomFarmer.GameObjects.Tools.WateringTools;
using FreedomFarmer.GameObjects.WaterSources;

namespace FreedomFarmer
{
    public delegate void DayIncrimentedEventHandler(object sender, EventArgs e);

    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class FreedomFarmerGame : Microsoft.Xna.Framework.Game
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

        public FreedomFarmerGame()
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

            //Create a pot.
            //Later on we'll have a pot tool that can be used to add a pot to your grow slot.
            ClayPot myClayPot = new ClayPot(this);

            //Create a soil tool.  Going to use ph balanced soil here.
            PHBalancedSoilTool mySoil = new PHBalancedSoilTool(this);

            //Create a white widow seed.
            WhiteWidowSeedTool myWhiteWidowSeedTool = new WhiteWidowSeedTool(this);

            //Create an empty soda bottle tool.  It's a low capacity bottle that dispenses a tiny amount of water.
            EmptySodaBottleTool myEmptySodaBottle = new EmptySodaBottleTool(this) { RemainingWater = 1.0 };

            //Create a water source, my sink, don't have a purifier yet.
            SinkWaterSource mySink = new SinkWaterSource(this) { Quality = 0.5 };

            //Use the soil tool with the pot to add soil to the pot.
            mySoil.Use(myClayPot);

            //Use the seed tool to add the seed to the soil.
            myWhiteWidowSeedTool.Use(myClayPot);

            //Use the empty soda bottle to add water to the soil.
            myEmptySodaBottle.Use(myClayPot);

            //Use the empty soda bottle tool with the sink to refill it with water.
            myEmptySodaBottle.Use(mySink);


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
