using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;


namespace JARVIS_Virtual_Assistant
{
    internal class SpeechEngine
    {
        private SpeechSynthesizer synthesizer;

        public SpeechEngine()
        {
            synthesizer = new SpeechSynthesizer();
        }

        public void Speak(string text)
        {
            synthesizer.Speak(text);
        }
    }
}
