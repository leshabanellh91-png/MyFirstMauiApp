using Microsoft.Maui.Controls;

namespace MyFirstMauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            CounterBtn.Text = count == 1
                ? $"Clicked {count} time"
                : $"Clicked {count} times";

            ResultLabel.Text = "Button clicked 🎉";
        }
        private void OnResetClicked(object sender, EventArgs e)
        {
            count = 0; // Reset counter
            CounterBtn.Text = "Click Me"; // Reset button text
            ResultLabel.Text = "Counter reset 🔄"; // Show message
        }

    }
}
