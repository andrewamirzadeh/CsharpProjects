using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartHome3
{
    //Bijan Amirzadehasl 07/11/2021
    public partial class Form1 : Form
        //initialize variables for images into Bitmap types
    {
        Bitmap lightOn = Properties.Resources.LightOn;
        Bitmap lightOff = Properties.Resources.LightOff;
        Bitmap togOn = Properties.Resources.ToggleOn;
        Bitmap togOff = Properties.Resources.ToggleOff;
        public Form1()
        {
            //initialize constructor for the form with toggle on by default
            InitializeComponent();
            pictureBoxPLTog.Image = togOn;
            pictureBoxFYTog.Image = togOn;
            pictureBoxBYTog.Image = togOn;
            pictureBoxBRTog.Image = togOn;
            pictureBoxKTog.Image = togOn;
        }

        //the next five functions/events are testing picturbox.image by the variables above
        //pictureboxPLTog.Image == properties.resource.toggle on doesnt work thats why
        // i did it this way. to test against a variable type
        private void pictureBoxPLTog_Click(object sender, EventArgs e)
        {
            if (pictureBoxPLTog.Image == togOn)
            {
                pictureBoxPLTog.Image = togOff;
                pictureBoxPorch.Image = lightOff;
            }
            else
            {
                pictureBoxPLTog.Image = togOn;
                pictureBoxPorch.Image = lightOn;
            }
        }
        private void pictureBoxFYTog_Click(object sender, EventArgs e)
        {
            if (pictureBoxFYTog.Image == togOn)
            {
                pictureBoxFYTog.Image = togOff;
                pictureBoxFrontYard.Image = lightOff;
            }
            else
            {
                pictureBoxFYTog.Image = togOn;
                pictureBoxFrontYard.Image = lightOn;
            }
        }

        private void pictureBoxBYTog_Click(object sender, EventArgs e)
        {
            if (pictureBoxBYTog.Image == togOn)
            {
                pictureBoxBYTog.Image = togOff;
                pictureBoxBackYard.Image = lightOff;
            }
            else
            {
                pictureBoxBYTog.Image = togOn;
                pictureBoxBackYard.Image = lightOn;
            }
        }

        private void pictureBoxBRTog_Click(object sender, EventArgs e)
        {
            if (pictureBoxBRTog.Image == togOn)
            {
                pictureBoxBRTog.Image = togOff;
                pictureBoxBedroom.Image = lightOff;
            }
            else
            {
                pictureBoxBRTog.Image = togOn;
                pictureBoxBedroom.Image = lightOn;
            }
        }

        private void pictureBoxKTog_Click(object sender, EventArgs e)
        {
            if (pictureBoxKTog.Image == togOn)
            {
                pictureBoxKTog.Image = togOff;
                pictureBoxKitchen.Image = lightOff;
            }
            else
            {
                pictureBoxKTog.Image = togOn;
                pictureBoxKitchen.Image = lightOn;
            }
        }


        //Five "Scene" events/functions that assigns the picturebox.Image to the initialized
        //variable set up in the global space above.
        private void pictureBoxALLOn_Click(object sender, EventArgs e)
        {
            pictureBoxPorch.Image = lightOn;
            pictureBoxPLTog.Image = togOn;
            pictureBoxFrontYard.Image = lightOn;
            pictureBoxFYTog.Image = togOn;
            pictureBoxBackYard.Image = lightOn;
            pictureBoxBYTog.Image = togOn;
            pictureBoxBedroom.Image = lightOn;
            pictureBoxBRTog.Image = togOn;
            pictureBoxKitchen.Image = lightOn;
            pictureBoxKTog.Image = togOn;

        }

        private void pictureBoxAllOFF_Click(object sender, EventArgs e)
        {
            pictureBoxPorch.Image = lightOff;
            pictureBoxPLTog.Image = togOff;
            pictureBoxFrontYard.Image = lightOff;
            pictureBoxFYTog.Image = togOff;
            pictureBoxBackYard.Image = lightOff;
            pictureBoxBYTog.Image = togOff;
            pictureBoxBedroom.Image = lightOff;
            pictureBoxBRTog.Image = togOff;
            pictureBoxKitchen.Image = lightOff;
            pictureBoxKTog.Image = togOff;
        }

        private void pictureBoxOSon_Click(object sender, EventArgs e)
        {
            pictureBoxPorch.Image = lightOn;
            pictureBoxPLTog.Image = togOn;
            pictureBoxFrontYard.Image = lightOn;
            pictureBoxFYTog.Image = togOn;
            pictureBoxBackYard.Image = lightOn;
            pictureBoxBYTog.Image = togOn;
        }

        private void pictureBoxOSoff_Click(object sender, EventArgs e)
        {
            pictureBoxPorch.Image = lightOff;
            pictureBoxPLTog.Image = togOff;
            pictureBoxFrontYard.Image = lightOff;
            pictureBoxFYTog.Image = togOff;
            pictureBoxBackYard.Image = lightOff;
            pictureBoxBYTog.Image = togOff;
        }

        private void pictureBoxINon_Click(object sender, EventArgs e)
        {
            pictureBoxBedroom.Image = lightOn;
            pictureBoxBRTog.Image = togOn;
            pictureBoxKitchen.Image = lightOn;
            pictureBoxKTog.Image = togOn;
        }

        private void pictureBoxINoff_Click(object sender, EventArgs e)
        {
            pictureBoxBedroom.Image = lightOff;
            pictureBoxBRTog.Image = togOff;
            pictureBoxKitchen.Image = lightOff;
            pictureBoxKTog.Image = togOff;
        }

      
       
    }
    }

