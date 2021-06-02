using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СockroachRace
{
    public partial class Race : Form
    {
        //ThreadManager threadManager;
        Random rnd;
        public Race()
        {
            InitializeComponent();            
            rnd = new Random();
        }

        bool someCockroachFinished = false;

        public void CockroachRun(object cockroach)
        {
            //if (someCockroachFinished)
            //    Thread.CurrentThread.Abort();

            PictureBox pb = (PictureBox)cockroach;
            while (pb.Location.X < 1410 && !someCockroachFinished)
            {                
                Thread.Sleep(rnd.Next(0, 20));
                Action action = () => pb.Location = new Point(pb.Location.X + rnd.Next(0, 20), pb.Location.Y);// + rnd.Next(0, 10)- rnd.Next(0, 10));  
                Invoke(action);
            }
            
            
            if (!someCockroachFinished)
            {
                string winnerName = Thread.CurrentThread.Name;
                Action action = () => winnerLbl.Text = $"The winner is {winnerName}!!!";
                Invoke(action);
                someCockroachFinished = true;
                Thread.CurrentThread.Abort();
            }
            else
                Thread.CurrentThread.Abort();

        }

        private void GetReady()
        {
            string winnerName = string.Empty;
            for (int i = 3; i > 0; i--)
            {
                Action action = () => winnerLbl.Text = $"{i}";
                Invoke(action);
                Thread.Sleep(1000);
            }

            Action action1 = () => winnerLbl.Text = string.Empty;
            Invoke(action1);

            Thread t1 = new Thread(new ParameterizedThreadStart(CockroachRun));
            t1.Name = "Cockroach №1";
            //t1.Priority = ThreadPriority.Lowest;
            t1.Start(cockroach1PB);

            Thread t2 = new Thread(new ParameterizedThreadStart(CockroachRun));
            t2.Name = "Cockroach №2";
            //t2.Priority = ThreadPriority.Lowest;
            t2.Start(cockroach2PB);

            Thread t3 = new Thread(new ParameterizedThreadStart(CockroachRun));
            t3.Name = "Cockroach №3";
            //t3.Priority = ThreadPriority.Lowest;
            t3.Start(cockroach3PB);
           
            Thread.CurrentThread.Abort();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            Thread t0 = new Thread(new ThreadStart(GetReady));
            //t0.Priority = ThreadPriority.Highest;
            t0.Start();

            cockroach1PB.Location = new Point(87, 165);
            cockroach2PB.Location = new Point(87, 369);
            cockroach3PB.Location = new Point(87, 571);
            someCockroachFinished = false;
            winnerLbl.Text = string.Empty;
        }
    }
}
