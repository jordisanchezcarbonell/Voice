using System;
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

namespace WindowsFormsAppVoice
{
    public partial class Form1 : Form
    {
        private string args = "Jordi";
        Choices list = new Choices();
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        public Form1()
        {
            
            synthesizer.SelectVoiceByHints(VoiceGender.Male); //Seleccionar la voz
            SpeechRecognitionEngine rec = new SpeechRecognitionEngine();                                                                   
            list.Add(new String[] { "Hola", "Como estas" });
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
            synthesizer.SpeakAsync("Bienvenido,"+""+ args); 

        }
        
        private void decir(String h)
        {
            synthesizer.Speak(h);
        }


        private void rec_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            String result = e.Result.Text;

            //LO QUE DECIMO
            if (result == "Hola")
            {
                // LO QUE DICE
                decir("Hola");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           //peech(args);
        }


       
    }
}
