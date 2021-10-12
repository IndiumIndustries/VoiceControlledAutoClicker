using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;

namespace VoiceControlled
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer speech = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
           
            Choices choices = new Choices();
            string[] text = File.ReadAllLines("vocals.txt");
            choices.Add(text);
            Grammar gramar = new Grammar(new GrammarBuilder(choices));
            recEngine.LoadGrammar(gramar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            recEngine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recEngine_SpeechRecognized);

            speech.SelectVoiceByHints(VoiceGender.Male);
        }


        



      

        

     

        private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string result = e.Result.Text;
            if(result == "Autoclicker Enable") 
            {
                result = "Autoclicker Enabled";
                
            }
            if (result == "Autoclicker Disable")
            {
                result = "Autoclicker Disabled";
                
            }
            if (result == "Autoclicker Destruct")
            {
                result = "Autoclicker Destruct";

            }
            if (result == "Auto clicker what is my cps")
            {
                result = "Your CPS IS " + trackBar1.Value;

            }
            if (result == "Auto clicker set bind f")
            {
                result = "Your Bind Has Been Set To F";

            }
            if (result == "Auto clicker set bind r")
            {
                result = "Your Bind Has Been Set To R";

            }
            speech.SpeakAsync(result);

            label1.Text = result;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Text == "Auto clicker Enabled")
            {
                checkBox1.Checked = true;
            }
            if (label1.Text == "Auto clicker Disabled")
            {
                checkBox1.Checked = false;

            }
            if (label1.Text == "Auto clicker Destruct")
            {
                System.Environment.Exit(0);

            }
            if (label1.Text == "Auto clicker CPS 10")
            {
                trackBar1.Value = 10;

            }
            if (label1.Text == "Auto clicker CPS 11")
            {
                trackBar1.Value = 11;

            }
            if (label1.Text == "Auto clicker CPS 12")
            {
                trackBar1.Value = 12;

            }
            if (label1.Text == "Auto clicker CPS 13")
            {
                trackBar1.Value = 13;

            }

            if (label1.Text == "Auto clicker CPS 14")
            {
                trackBar1.Value = 14;

            }

            if (label1.Text == "Auto clicker CPS 15")
            {
                trackBar1.Value = 15;

            }

            if (label1.Text == "Auto clicker CPS 16")
            {
                trackBar1.Value = 16;

            }
            if (label1.Text == "Auto clicker CPS 17")
            {
                trackBar1.Value = 17;

            }
            if (label1.Text == "Auto clicker CPS 18")
            {
                trackBar1.Value = 18;

            }
            if (label1.Text == "Auto clicker CPS 19")
            {
                trackBar1.Value = 19;

            }


            if (label1.Text == "Your Bind Has Been Set To R")
            {
                

            }
            if (label1.Text == "Your Bind Has Been Set To F")
            {

            }
            if (label1.Text == "Auto clicker play mario")
            {
                label1.Text = "Done!";
                bool yourBool = false;
                Random rand = new Random();

                if (rand.Next(0, 2) != 0)
                {
                    yourBool = true;
                }
                if(yourBool == true) 
                {
                    Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
                }
                else 
                {
                    speech.SpeakAsync("No, im good.");
                }
            }


            label2.Text = "CPS: " + trackBar1.Value;



        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
           
        }
           
        }    
    }

