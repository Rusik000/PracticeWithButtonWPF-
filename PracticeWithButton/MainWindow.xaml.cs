using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Controls;


namespace PracticeWithButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Random random = new Random();


        private void FiveBtn_Click(object sender, RoutedEventArgs e)
        {
            var r = Convert.ToByte(random.Next(0, 255));
            var g = Convert.ToByte(random.Next(0, 255));
            var b = Convert.ToByte(random.Next(0, 255));
            FiveBtn.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        private void SixBtn_Click(object sender, RoutedEventArgs e)
        {
            var r = Convert.ToByte(random.Next(0, 255));
            var g = Convert.ToByte(random.Next(0, 255));
            var b = Convert.ToByte(random.Next(0, 255));
            SixBtn.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        private void ForthBtn_Click(object sender, RoutedEventArgs e)
        {

            var r = Convert.ToByte(random.Next(0, 255));
            var g = Convert.ToByte(random.Next(0, 255));
            var b = Convert.ToByte(random.Next(0, 255));
            ForthBtn.Background = new SolidColorBrush(Color.FromRgb(r, g, b));

        }

        private void ThirdBtn_Click(object sender, RoutedEventArgs e)
        {

            var r = Convert.ToByte(random.Next(0, 255));
            var g = Convert.ToByte(random.Next(0, 255));
            var b = Convert.ToByte(random.Next(0, 255));
            ThirdBtn.Background = new SolidColorBrush(Color.FromRgb(r, g, b));

        }

        private void SecondBtn_Click(object sender, RoutedEventArgs e)
        {
            var r = Convert.ToByte(random.Next(0, 255));
            var g = Convert.ToByte(random.Next(0, 255));
            var b = Convert.ToByte(random.Next(0, 255));
            SecondBtn.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        private void FirstBtn_Click(object sender, RoutedEventArgs e)
        {
            var r = Convert.ToByte(random.Next(0, 255));
            var g = Convert.ToByte(random.Next(0, 255));
            var b = Convert.ToByte(random.Next(0, 255));
            FirstBtn.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }


        private void FirstBtn_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Grid.Children.Remove(FirstBtn);
           
            this.Title = FirstBtn.Content.ToString();

        }
        private void SecondBtn_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Grid.Children.Remove(SecondBtn);
            this.Title = SecondBtn.Content.ToString();
            
        }


        private void ThirdBtn_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

            Grid.Children.Remove(ThirdBtn);
            this.Title = ThirdBtn.Content.ToString();
            
        }

        private void ForthBtn_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Grid.Children.Remove(ForthBtn);
            this.Title = ForthBtn.Content.ToString();
            
        }

        private void FiveBtn_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Grid.Children.Remove(FiveBtn);
            this.Title = FiveBtn.Content.ToString();
            
        }

        private void SixBtn_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Grid.Children.Remove(SixBtn);
            this.Title = SixBtn.Content.ToString();
           
        }


       
    }
}
