using StardewModdingAPI;
using StardewModdingAPI.Events;
using SDVWM_Example_Addon.Extension;

namespace SDVWM_Example_Addon
{

        /// <summary>The mod entry point.</summary>
        public class ModEntry : Mod
        {
            public static bool gamelaunched = false;

            // Base Configuration
            Extension_Loader _Loader = new Extension_Loader(); // Load config from Master


            /*********
            ** Public methods
            *********/
            /// <summary>The mod entry point, called after the mod is first loaded.</summary>
            /// <param name="helper">Provides simplified APIs for writing mods.</param>
            public override void Entry(IModHelper helper)
            {

                /* Event Helpers */
                helper.Events.GameLoop.DayStarted += this.OnDayStarted;
                helper.Events.GameLoop.GameLaunched += this.GameLaunched;

        }


        /*********
        ** Private methods
        *********/
        /// <summary>Raised after the player presses a button on the keyboard, controller, or mouse.</summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event data.</param>

        private void GameLaunched(object sender, GameLaunchedEventArgs e)
        {
            /// ########################################### ///
            ///       Check if SDVWM is installed          ///
            /// ########################################## ///

            if (_Loader.Load_Configuration() == true)
            {
                this.Monitor.Log("Hello SDVWM!", LogLevel.Info);
            }

            if (_Loader.Load_Configuration() == false)
            {
                this.Monitor.Log("Hello World, where is SDVWM?", LogLevel.Info);
            }

        }

        private void OnDayStarted(object sender, DayStartedEventArgs e)
            {

            // Display the weather summary from SDVWM.ini file whenever a new day starts.
            this.Monitor.Log("It's currently: " + _Loader.Load_Weather_Summary(), LogLevel.Info);

            }

        }


}

