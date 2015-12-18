using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
<<<<<<< HEAD
        private KeyboardState oldState;
=======
        KeyboardState oldState;
        private string word;
        private char[] wordSplit;
        int charCount;

>>>>>>> refs/remotes/origin/jenga
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
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

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
<<<<<<< HEAD
                // gets a string from the list, splits it into an array and gets it's length in and int
            StringHandling sHandler = new StringHandling();
            string word = sHandler.chooseWord();
            char[] wordSplit = word.ToCharArray();
            int charCount = word.Length;

            //User input
            KeyboardState newState = Keyboard.GetState();
            if (oldState.IsKeyUp(Keys.Left) && newState.IsKeyDown(Keys.Left))
            {
                // do something here
                // this will only be called when the key if first pressed
            }
            oldState = newState;

=======
            //Gets a string, creates an array of it's character, creates an int equal to it's length
            StringHandling sHandler = new StringHandling();
            
            if(word == null)
            {
                word = sHandler.chooseWord();
                wordSplit = word.ToCharArray();
                charCount = word.Length;

            }
            

            //input handling
            string inString; // where inputted letters will be stored when input is received
            KeyboardState newState = Keyboard.GetState(); // gets the current state of keyboard
            Keys[] keys = newState.GetPressedKeys(); // gets an array of all the keyboard buttons pressed
            foreach (Keys key in keys)
            {
                if (oldState.IsKeyUp(key) && keys.Length == 1 && word != null) // makes sure only one key is pressed, isn't spammed and that a word is actually chosen, basically preventing cheating and errors and instantly losing
                {
                    
                    inString = keys[0].ToString(); // stores inputted letter
                    string lowerInString = inString.ToLower(); // needs to be lower case for comparison to lowercase word that was selected, all words in array are totally lowercase
                    for(int i = 0; i < charCount; i++)
                    {
                        if(wordSplit[i].ToString() == lowerInString)
                        {
                            //input letter matches one in the word
                        }
                        else
                        {
                            //input letter doesnt match

                        }
                    }
                }
                else
                {
                    //inform the user to only press one key at a time etc, user friendly bullshit
                }
                
            }

            oldState = newState;
>>>>>>> refs/remotes/origin/jenga


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
    }
}
