using System;
using TextToSpeechXamarin.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TextToSpeechXamarin.Views
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class AboutPage : ContentPage
  {
    public AboutPage()
    {
      InitializeComponent();

      var speak = new Button
      {
        Text = "Hello, Forms !",
        VerticalOptions = LayoutOptions.CenterAndExpand,
        HorizontalOptions = LayoutOptions.CenterAndExpand,
      };
      speak.Clicked += (sender, e) => {
        DependencyService.Get<ITextToSpeech>().Speak("Hello from Xamarin Forms");
      };
      Content = speak;
    }
  }
}