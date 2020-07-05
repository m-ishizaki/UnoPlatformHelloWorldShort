using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Input;

namespace UnoApp1.Shared
{
    class MainPageViewModel : BindableBase
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        private string _firstText;
        private string _secondText;
        private string _text;
        private IEnumerable<Spetialty> _specialties;

        public string FirstText { get => _firstText; set => SetProperty(ref _firstText, value); }
        public string SecondText { get => _secondText; set => SetProperty(ref _secondText, value); }
        public string Text { get => _text; set => SetProperty(ref _text, value); }
        public IEnumerable<Spetialty> Specialties { get => _specialties; set => SetProperty(ref _specialties, value); }

        public ICommand TextCommand { get; }
        public ICommand GetCommand { get; }

        public MainPageViewModel()
        {
            TextCommand = new Command { Action = OnText };
            GetCommand = new Command { Action = OnGet };
        }

        private void OnText(object parameter) => Text = FirstText + SecondText;
        private async void OnGet(object parameter) => Specialties = JsonSerializer.Deserialize<Spetialty[]>
            (
                await _httpClient.GetStringAsync
                (
                    "https://raw.githubusercontent.com/m-ishizaki/UnoPlatformHelloWorldShort/master/src/api/saitamas.json"
                )
            );
    }
}
