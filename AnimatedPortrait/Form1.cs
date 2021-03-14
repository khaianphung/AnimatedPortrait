using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using StardewValley;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;
using System.IO;

namespace AnimatedPortrait
{

    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            SetProcessDPIAware();
            Rectangle appRect;
            GetWindowRect(GetForegroundWindow(), out appRect);
            //Rectangle appRect = getActiveWindowBounds();
            this.Size = new Size(appRect.Width, appRect.Height);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Opacity = 0.99;
            this.TopMost = true;
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            this.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point((this.Width - pictureBox1.Width) / 2, (this.Height - pictureBox1.Height) /2);
            pictureBox1.Size = new Size(1, 1);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //do whatever you want 
            if (Game1.dialogueUp && Game1.currentSpeaker != null)
            {
                resetPicture();


            }
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Game1.dialogueUp && Game1.currentSpeaker != null)
            {
                resetPicture();

            }
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            if (Game1.dialogueUp && Game1.currentSpeaker != null)
            {
                resetPicture();

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Game1.dialogueUp && Game1.currentSpeaker != null)
            {
                resetPicture();

            }
        }

        public void emptyPictureBox()
        {
            pictureBox1.Image = null;

        }
        public void resetPicture()
        {
            string emotion = "";
            string characterName = Game1.currentSpeaker.Name;
            string path = Directory.GetCurrentDirectory();


            if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$neutral"
                || Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "0")
            {
                emotion = "neutral";
            }
            else if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$h"
                || Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "1")
            {
                emotion = "happy";
            }
            else if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$s"
                || Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "2")
            {
                emotion = "sad";
            }
            else if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$u")
            {
                emotion = "unique";
            }
            else if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$3")
            {
                emotion = "3";
            }
            else if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$l")
            {
                emotion = "love";
            }
            else if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$4")
            {
                emotion = "4";
            }
            else if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$a")
            {
                emotion = "angry";
            }
            else if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$5")
            {
                emotion = "5";
            }
            else if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$6")
            {
                emotion = "6";
            }
            else if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$7")
            {
                emotion = "7";
            }
            else if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$8")
            {
                emotion = "8";
            }
            else if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$9")
            {
                emotion = "9";
            }
            else if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$10")
            {
                emotion = "10";
            }


            if (characterName == ("Abigail"))
            {

                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Abigail\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Abigail\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Abigail\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Abigail\unique.gif");
                }
                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Abigail\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Abigail\love.gif");
                }
                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Abigail\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Abigail\angry.gif");
                }
                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Abigail\5.gif");
                }
                if (emotion == ("6"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Abigail\6.gif");
                }
                if (emotion == ("7"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Abigail\7.gif");
                }
                if (emotion == ("8"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Abigail\8.gif");
                }
                if (emotion == ("9"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Abigail\9.gif");
                }



            }
            else if (characterName == ("Alex"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Alex\neutral.gif");
                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Alex\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Alex\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Alex\unique.gif");
                }
                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Alex\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Alex\love.gif");
                }
                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Alex\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Alex\angry.gif");
                }
                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Alex\5.gif");
                }
                if (emotion == ("6"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Alex\6.gif");
                }
                if (emotion == ("7"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Alex\7.gif");
                }
                if (emotion == ("8"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Alex\8.gif");
                }
                if (emotion == ("9"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Alex\9.gif");
                }
                if (emotion == ("10"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Alex\10.gif");
                }
            }
            else if (characterName == ("Caroline"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Caroline\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Caroline\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Caroline\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Caroline\unique.gif");
                }

                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Caroline\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Caroline\love.gif");
                }

                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Caroline\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Caroline\angry.gif");
                }
                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Caroline\5.gif");
                }
            }
            else if (characterName == ("Clint"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Clint\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Clint\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Clint\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Clint\unique.gif");
                }
                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Clint\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Clint\love.gif");
                }

                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Clint\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Clint\angry.gif");
                }

                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Clint\5.gif");
                }

                if (emotion == ("6"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Clint\6.gif");
                }
                if (emotion == ("7"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Clint\7.gif");
                }
            }
            else if (characterName == ("Demetrius"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Demetrius\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Demetrius\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Demetrius\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Demetrius\unique.gif");
                }
                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Demetrius\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Demetrius\love.gif");
                }
                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Demetrius\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Demetrius\angry.gif");
                }
                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Demetrius\5.gif");
                }
                if (emotion == ("6"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Demetrius\6.gif");
                }
            }
            else if (characterName == ("Dwarf"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Dwarf\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Dwarf\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Dwarf\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Dwarf\unique.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Dwarf\love.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Dwarf\angry.gif");
                }
            }
            else if (characterName == ("Elliott"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Elliott\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Elliott\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Elliott\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Elliott\unique.gif");
                }
                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Elliott\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Elliott\love.gif");
                }
                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Elliott\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Elliott\angry.gif");
                }

                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Elliott\5.gif");
                }

                if (emotion == ("6"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Elliott\6.gif");
                }
                if (emotion == ("7"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Elliott\7.gif");
                }
                if (emotion == ("8"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Elliott\8.gif");
                }
            }
            else if (characterName == ("Emily"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Emily\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Emily\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Emily\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Emily\unique.gif");
                }
                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Emily\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Emily\love.gif");
                }
                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Emily\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Emily\angry.gif");
                }
                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Emily\5.gif");
                }
                if (emotion == ("6"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Emily\6.gif");
                }
                if (emotion == ("7"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Emily\7.gif");
                }
            }
            else if (characterName == ("Evelyn"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Evelyn\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Evelyn\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Evelyn\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Evelyn\unique.gif");
                }
                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Evelyn\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Evelyn\love.gif");
                }
                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Evelyn\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Evelyn\angry.gif");
                }
                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Evelyn\5.gif");
                }
            }
            else if (characterName == ("George"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\George\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\George\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\George\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\George\unique.gif");
                }
                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\George\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\George\love.gif");
                }
                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\George\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\George\angry.gif");
                }
                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\George\5.gif");
                }
            }
            else if (characterName == ("Gunther"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Gunther\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Gunther\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Gunther\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Gunther\unique.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Gunther\love.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Gunther\angry.gif");
                }
            }
            else if (characterName == ("Gus"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Gus\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Gus\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Gus\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Gus\unique.gif");
                }
                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Gus\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Gus\love.gif");
                }
                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Gus\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Gus\angry.gif");
                }
                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Gus\5.gif");
                }
            }
            else if (characterName == ("Haley"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Haley\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Haley\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Haley\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Haley\unique.gif");
                }
                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Haley\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Haley\love.gif");
                }
                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Haley\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Haley\angry.gif");
                }
                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Haley\5.gif");
                }



                if (emotion == ("6"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Haley\6.gif");

                }
                if (emotion == ("7"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Haley\7.gif");
                }
                if (emotion == ("8"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Haley\8.gif");
                }
                if (emotion == ("9"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Haley\9.gif");
                }
                if (emotion == ("10"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Haley\10.gif");
                }
                if (emotion == ("11"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Haley\11.gif");
                }
            }
            else if (characterName == ("Harvey"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Harvey\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Harvey\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Harvey\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Harvey\unique.gif");
                }

                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Harvey\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Harvey\love.gif");
                }

                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Harvey\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Harvey\angry.gif");
                }

                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Harvey\5.gif");
                }


                if (emotion == ("6"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Harvey\6.gif");

                }
                if (emotion == ("7"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Harvey\7.gif");
                }
                if (emotion == ("8"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Harvey\8.gif");
                }
                if (emotion == ("9"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Harvey\9.gif");
                }
                if (emotion == ("10"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Harvey\love.gif");
                }
                if (emotion == ("11"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Harvey\angry.gif");
                }
            }
            else if (characterName == ("Jas"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Jas\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Jas\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Jas\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Jas\unique.gif");
                }

                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Jas\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Jas\love.gif");
                }

                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Jas\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Jas\angry.gif");
                }

                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Jas\5.gif");
                }
            }
            else if (characterName == ("Jodi"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Jodi\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Jodi\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Jodi\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Jodi\unique.gif");
                }
                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Jodi\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Jodi\love.gif");
                }
                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Jodi\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Jodi\angry.gif");
                }
                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Jodi\5.gif");
                }
            }
            else if (characterName == ("Kent"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Kent\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Kent\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Kent\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Kent\unique.gif");
                }
                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Kent\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Kent\love.gif");
                }
                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Kent\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Kent\angry.gif");
                }
                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Kent\5.gif");
                }
            }
            else if (characterName == ("Leah"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Leah\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Leah\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Leah\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Leah\unique.gif");
                }

                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Leah\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Leah\love.gif");
                }

                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Leah\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Leah\angry.gif");
                }

                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Leah\5.gif");
                }

                if (emotion == ("6"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Leah\6.gif");
                }
                if (emotion == ("7"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Leah\7.gif");
                }
                if (emotion == ("8"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Leah\8.gif");
                }
            }
            else if (characterName == ("Lewis"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Lewis\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Lewis\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Lewis\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Lewis\unique.gif");
                }
                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Lewis\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Lewis\love.gif");
                }
                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Lewis\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Lewis\angry.gif");
                }
                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Lewis\5.gif");
                }
            }
            else if (characterName == ("Linus"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Linus\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Linus\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Linus\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Linus\unique.gif");
                }
                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Linus\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Linus\love.gif");
                }
                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Linus\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Linus\angry.gif");
                }
                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Linus\5.gif");
                }
            }
            else if (characterName == ("Marlon"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Marlon\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Marlon\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Marlon\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Marlon\unique.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Marlon\love.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Marlon\angry.gif");
                }
            }
            else if (characterName == ("Marnie"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Marnie\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Marnie\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Marnie\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Marnie\unique.gif");
                }
                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Marnie\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Marnie\love.gif");
                }
                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Marnie\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Marnie\angry.gif");
                }
                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Marnie\5.gif");
                }
            }
            else if (characterName == ("Maru"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Maru\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Maru\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Maru\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Maru\unique.gif");
                }

                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Maru\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Maru\love.gif");
                }

                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Maru\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Maru\angry.gif");
                }

                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Maru\5.gif");
                }


                if (emotion == ("6"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Maru\6.gif");
                }
                if (emotion == ("7"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Maru\7.gif");
                }
                if (emotion == ("8"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Maru\8.gif");
                }
                if (emotion == ("9"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Maru\9.gif");
                }
            }
            else if (characterName == ("Morris"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Morris\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Morris\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Morris\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Morris\unique.gif");
                }
                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Morris\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Morris\love.gif");
                }
                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Morris\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Morris\angry.gif");
                }
                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Morris\5.gif");
                }
            }
            else if (characterName == ("Pam"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Pam\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Pam\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Pam\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Pam\unique.gif");
                }
                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Pam\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Pam\love.gif");
                }
                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Pam\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Pam\angry.gif");
                }
                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Pam\5.gif");
                }
            }
            else if (characterName == ("Penny"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Penny\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Penny\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Penny\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Penny\unique.gif");
                }
                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Penny\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Penny\love.gif");
                }
                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Penny\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Penny\angry.gif");
                }
                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Penny\5.gif");
                }


                if (emotion == ("6"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Penny\6.gif");

                }
                if (emotion == ("7"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Penny\7.gif");
                }
                if (emotion == ("8"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Penny\8.gif");
                }
                if (emotion == ("9"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Penny\9.gif");
                }
                if (emotion == ("10"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Penny\10.gif");
                }
               
            }
            else if (characterName == ("Pierre"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Pierre\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Pierre\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Pierre\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Pierre\unique.gif");
                }
                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Pierre\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Pierre\love.gif");
                }
                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Pierre\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Pierre\angry.gif");
                }
                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Pierre\5.gif");
                }
            }
            else if (characterName == ("Robin"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Robin\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Robin\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Robin\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Robin\unique.gif");
                }
                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Robin\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Robin\love.gif");
                }
                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Robin\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Robin\angry.gif");
                }
                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Robin\5.gif");
                }
            }
            else if (characterName == ("Sam"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sam\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sam\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sam\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sam\unique.gif");
                }
                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sam\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sam\love.gif");
                }
                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sam\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sam\angry.gif");
                }
                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sam\5.gif");
                }


                if (emotion == ("6"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sam\6.gif");

                }
                if (emotion == ("7"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sam\7.gif");
                }
                if (emotion == ("8"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sam\8.gif");
                }
                if (emotion == ("9"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sam\9.gif");
                }
                if (emotion == ("10"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sam\10.gif");
                }
                
            }
            else if (characterName == ("Sandy"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sandy\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sandy\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sandy\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sandy\unique.gif");
                }
                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sandy\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sandy\love.gif");
                }
                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sandy\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sandy\angry.gif");
                }
                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sandy\5.gif");
                }
            }
            else if (characterName == ("Shane"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Shane\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Shane\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Shane\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Shane\unique.gif");
                }
                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Shane\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Shane\love.gif");
                }
                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Shane\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Shane\angry.gif");
                }
                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Shane\5.gif");
                }




                if (emotion == ("6"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Shane\6.gif");

                }
                if (emotion == ("7"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Shane\7.gif");
                }
                if (emotion == ("8"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Shane\8.gif");
                }
                if (emotion == ("9"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Shane\9.gif");
                }
                if (emotion == ("10"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Shane\10.gif");
                }
                
            }
            else if (characterName == ("Sebastian"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sebastian\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sebastian\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sebastian\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sebastian\unique.gif");
                }
                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sebastian\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sebastian\love.gif");
                }
                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sebastian\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sebastian\angry.gif");
                }
                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sebastian\5.gif");
                }


                if (emotion == ("6"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sebastian\6.gif");
                }
                if (emotion == ("7"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sebastian\7.gif");
                }
                if (emotion == ("8"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sebastian\8.gif");
                }
                if (emotion == ("9"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Sebastian\9.gif");
                }
            }
            else if (characterName == ("Vincent"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Vincent\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Vincent\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Vincent\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Vincent\unique.gif");
                }
                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Vincent\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Vincent\love.gif");
                }
                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Vincent\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Vincent\angry.gif");
                }
                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Vincent\5.gif");
                }
            }
            else if (characterName == ("Willy"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Willy\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Willy\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Willy\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Willy\unique.gif");
                }
                if (emotion == ("3"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Willy\3.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Willy\love.gif");
                }
                if (emotion == ("4"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Willy\4.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Willy\angry.gif");
                }
                if (emotion == ("5"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Willy\5.gif");
                }
            }
            else if (characterName == ("Wizard"))
            {
                if (emotion == ("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Wizard\neutral.gif");

                }
                if (emotion == ("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Wizard\happy.gif");
                }
                if (emotion == ("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Wizard\sad.gif");
                }
                if (emotion == ("unique"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Wizard\unique.gif");
                }
                if (emotion == ("love"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Wizard\love.gif");
                }
                if (emotion == ("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\AnimatedPortrait\assets\Pics\Wizard\angry.gif");
                }
            }
            pictureBox1.Location = new Point((this.Width - pictureBox1.Image.Width) / 2, (this.Height - pictureBox1.Image.Height) / 2);
            
        }



        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, out Rectangle lpRect);









    }
}