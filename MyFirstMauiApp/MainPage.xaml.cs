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

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            // Animate the button
            await CounterBtn.ScaleTo(1.2, 100);
            await CounterBtn.ScaleTo(1.0, 100);

            // Update button text
            CounterBtn.Text = count == 1
                ? $"Clicked {count} time"
                : $"Clicked {count} times";

            // Update label and animate
            ResultLabel.Text = "Button clicked 🎉";
            await ResultLabel.ScaleTo(1.3, 100);
            await ResultLabel.ScaleTo(1.0, 100);

            // Show alert when count reaches 5
            if (count == 5)
            {
                await DisplayAlert(
                    "Congratulations!",
                    "You clicked the button 5 times 🎉",
                    "OK");
            }
        }

        private void OnResetClicked(object sender, EventArgs e)
        {
            count = 0;
            CounterBtn.Text = "Click Me";
            ResultLabel.Text = "Counter reset 🔄";
        }
    }
}
