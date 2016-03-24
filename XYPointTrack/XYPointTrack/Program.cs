﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeXFramework;
using Tobii.EyeX.Framework;

namespace XYPointTrack
{
    class Program
    {


        public void displayEyeGaze(object sender, GazePointEventArgs e)
        {
            Console.WriteLine(e.X + " " + e.Y);
        }


        static void Main(string[] args)
        {

            using (var eyeXHost = new EyeXHost())
            {
                // Create a data stream: lightly filtered gaze point data.
                // Other choices of data streams include EyePositionDataStream and FixationDataStream.
                using (var lightlyFilteredGazeDataStream = eyeXHost.CreateGazePointDataStream(GazePointDataMode.LightlyFiltered))
                {
                    // Start the EyeX host.
                    eyeXHost.Start();

                    // Write the data to the console.

                    //Create the Deligate

                    EventHandler<GazePointEventArgs> displaydel = new EventHandler<GazePointEventArgs>(displayEyeGaze);

                    lightlyFilteredGazeDataStream.Next += displaydel;

                    // Let it run until a key is pressed.
                    Console.WriteLine("Listening for gaze data, press any key to exit...");
                    Console.In.Read();
                }
            }


        }
    }
}
