using System.Windows;

namespace OkapiBrowser
{
    public partial class QuickFillPINWindow : Window
    {
        public QuickFillPINWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        internal string GetPIN()
        {
            return this.PIN.Text;
        }
    }
}
