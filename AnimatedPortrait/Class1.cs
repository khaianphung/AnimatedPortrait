using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;
using StardewValley.Menus;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace AnimatedPortrait
{

    /// <summary>The mod entry point.</summary>
    public class ModEntry : Mod
    {
        Form1 f1;
        bool running = true;
        /*********
        ** Public methods
        *********/
        /// <summary>The mod entry point, called after the mod is first loaded.</summary>
        /// <param name="helper">Provides simplified APIs for writing mods.</param>
        public override void Entry(IModHelper helper)
        {
            helper.Events.GameLoop.SaveLoaded += this.OnSaveLoaded;
            helper.Events.Input.ButtonPressed += this.OnButtonPressed;
        }

        //was private
        private void OnSaveLoaded(object sender, SaveLoadedEventArgs e)
        {

            f1 = new Form1();
            f1.emptyPictureBox();
        }

        /*********
        ** Private methods
        *********/
        /// <summary>Raised after the player presses a button on the keyboard, controller, or mouse.</summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event data.</param>
        /// 
        //was PRIVATE


        private void OnButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            if (!Context.IsWorldReady)
                return;
            if (Game1.dialogueUp && Game1.currentSpeaker != null)
            {
                this.Monitor.Log($"{Game1.currentSpeaker.Name} {Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion}.", LogLevel.Debug);
                if (running == true)
                {
                    if (f1.IsDisposed)
                    {
                        f1 = new Form1();
                        f1.emptyPictureBox();
                        f1.Show();
                    }
                    f1.resetPicture();
                }
                if (running == false && e.Button.ToString() == "H")
                {
                    f1 = new Form1();
                    f1.resetPicture();
                    f1.Show();
                    running = true;
                }

                else if (running == true && e.Button.ToString() == "H")
                {
                    f1.Close();
                    running = false;
                }
            }
            else if (!Game1.dialogueUp && running == true)
            {
                f1.Close();
            }
        }
    }
}