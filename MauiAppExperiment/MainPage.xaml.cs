using System.Diagnostics;

namespace MauiAppExperiment
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

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void MyButtonClick(object sender, EventArgs e)
        {
            if (EntryField.Text == "test")
            {
                Trace.WriteLine("test successful");
                EntryField.Text = "test successful";
            }
        }
    }

}
