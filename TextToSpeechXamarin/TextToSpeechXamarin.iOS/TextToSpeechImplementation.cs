using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using TextToSpeechXamarin.Services;
using TextToSpeechXamarin.iOS;
using Xamarin.Forms;
using AVFoundation;

[assembly: Dependency(typeof(TextToSpeechImplementation))]
namespace TextToSpeechXamarin.iOS
{
  public class TextToSpeechImplementation : ITextToSpeech
  {
    public TextToSpeechImplementation() { }
    public void Speak(string text)
    {
      var speechSynthesizer = new AVSpeechSynthesizer();
      var speechUtterance = new AVSpeechUtterance(text)
      {
        Rate = AVSpeechUtterance.MaximumSpeechRate / 4,
        Voice = AVSpeechSynthesisVoice.FromLanguage("de-DE"),
        Volume = 0.5f,
        PitchMultiplier = 1.0f
      };

      speechSynthesizer.SpeakUtterance(speechUtterance);
    }
  }
}