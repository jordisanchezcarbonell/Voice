﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Diagnostics;

namespace WindowsFormsAppVoice
{
    public partial class Form1 : Form
    {
        private string args = "Jordi";
        Choices list = new Choices();
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        Boolean abrir = true;
        public Form1()
        {
            InitializeComponent();
            synthesizer.SelectVoiceByHints(VoiceGender.Male); //Seleccionar la voz
            SpeechRecognitionEngine rec = new SpeechRecognitionEngine();
            list.Add(new String[] { "Hola", "Como estas", "Abre google", "abrir", "dormir", "restart" ,"abre openoffice"});

            Grammar gr = new Grammar(new GrammarBuilder(list));
            try
            {
                rec.RequestRecognizerUpdate();
                rec.LoadGrammar(gr);


                rec.SpeechRecognized += rec_SpeechRecognized;
                rec.SetInputToDefaultAudioDevice();
                rec.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
            synthesizer.Speak("Hola, soy tu asistente");
            // Asynchronous
            synthesizer.SpeakAsync("Bienvenido," + "" + args);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private static void matarproceso(String Proceso)
        {
            System.Diagnostics.Process[] proc = null;
            try
            {
                proc = Process.GetProcessesByName(Proceso);
                Process prog = proc[0];
                if (!prog.HasExited)
                {
                    prog.Kill();
                }
            }
            finally
            {
                if (proc != null)
                {
                    foreach(Process p in proc)
                    {
                        p.Dispose();
                    }
                }
            }
        }
        private void decir(String h)
        {
            synthesizer.Speak(h);
            textBoxinput.AppendText(h + "\n");
        }


        private void rec_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            String result = e.Result.Text;

            if (result == "abrir")
            {
                abrir = true;
                labelestado.Text = "Estado: On";
            }
            if (result == "dormir")
            {
                abrir = false;

                labelestado.Text = "Estado: OFF";
            }
            if (abrir==true)
            {
                //LO QUE DECIMO
                if (result == "Hola")
                {
                    // LO QUE DICE
                    decir("Hola");
                }
                if(result=="abre openoffice")
                {
                    Process.Start("C:\\Program Files (x86)\\OpenOffice 4\\program\\soffice.exe");
                }
                if (result == "cerrar openoffice")
                {
                    matarproceso("soffice.bin");
                }

                if (result == "restart")
                {
                    restart();
                }
                if (result == "Abre google")
                {
                    Process.Start("https://www.google.es");
                }

                textBoxoutput.AppendText(result + "\n");

            }
        }

        private void restart()
        {
           // Process.Start("C:\\Users\\jordi\\source\repos\\WindowsFormsAppVoice\\WindowsFormsAppVoice\bin\\Debug\\WindowsFormsAppVoice.exe");
            Environment.Exit(0);

        }
    }
}
