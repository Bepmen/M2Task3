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

namespace M2Task3._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
                textBox.FontFamily = new FontFamily(fontName);
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            double fontHeight = Convert.ToDouble(((sender as ComboBox).SelectedItem as TextBlock).Text);
            if (textBox != null)
                textBox.FontSize = fontHeight;
        }

        #region Обработчики ToolBar "Кнопки"

        bool isBold;
        bool isItalic;
        bool isDecoration;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!isBold)
                textBox.FontWeight = FontWeights.Bold;
            else
                textBox.FontWeight = FontWeights.Normal;
            isBold = !isBold;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!isItalic)
                textBox.FontStyle = FontStyles.Italic;
            else
                textBox.FontStyle = FontStyles.Normal;
            isItalic = !isItalic;
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (!isDecoration)
                textBox.TextDecorations = TextDecorations.Underline;
            else
                textBox.TextDecorations = null;
            isDecoration = !isDecoration;
        }

        #endregion


        private void radio1_Click(object sender, RoutedEventArgs e)
        {
            textBox.Foreground = Brushes.Black;
        }


        private void radio2_Click(object sender, RoutedEventArgs e)
        {
            textBox.Foreground = Brushes.Red;

        }


    }
}
