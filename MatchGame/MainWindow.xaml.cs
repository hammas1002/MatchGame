using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //constructor
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            //   throw new NotImplementedException(); //  acts as a reminder.

            List<string> emojis = new List<string>()
            {
                "😂","😂",
                "❤","❤",
                "😜","😜",
                "🎶","🎶",
                "‍🚀","‍🚀",
                "🤦‍","🤦‍",
                "💖","💖",
                "🌹","🌹",

            };
            Random random = new Random();
            foreach(TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                int index = random.Next(emojis.Count);
                textBlock.Text = emojis[index];
                emojis.RemoveAt(index);
            }
        }
    }
}
