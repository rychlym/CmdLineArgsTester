using Avalonia.Controls;
using CmdLineArgsTester.Infra;

namespace CmdLineArgsTester
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            string result = null;
            if (AppSettings.Args.Length > 0)
            {
                var i = 1;
                result = "";
                foreach (var arg in AppSettings.Args)
                {
                    result += $"{i}. {arg}\n";
                    i++;
                }
            }
            else
            {
                result = "no app settings";
            }
            Results.Text = result;
        }
    }
}