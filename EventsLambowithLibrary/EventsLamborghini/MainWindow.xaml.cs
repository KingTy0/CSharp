using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestProjectStub;
using TestStubLibrary;
using EventsLamborghini.ViewModels;
namespace EventsLamborghini
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SuperCarViewModel SCVM;
        public MainWindow()
        {
            InitializeComponent();
            lamborgini = new Lamborghini();
            ferrari = new Ferrari();
            SCVM = new SuperCarViewModel(new Lamborghini());
            this.DataContext = SCVM;
        }
        int Counter = 0;
        Lamborghini lamborgini;
        Ferrari ferrari;

        private void UpdateUI()
        {
            CurrentGearLamboTXB.Text = lamborgini.transmission.currentGear.ToString();
            CurrentGearFerrariTXB.Text = ferrari.transmission.currentGear.ToString();

        }

        #region StartUp/HideStuff
        public void StartUPCarLambo()
        {
            lamborgini.StartUP();

            LamboDriveForwardBtn.Visibility = Visibility.Visible;

            LamboLaunchControlBtn.Visibility = Visibility.Visible;
            CurrentGearLambolbl.Visibility = Visibility.Visible;
            CurrentGearLamboTXB.Visibility = Visibility.Visible;
            ShiftUpGearLambo.Visibility = Visibility.Visible;
            ShiftDownGearLambo.Visibility = Visibility.Visible;
        }
        public void StartUpFerrari()
        {
            ferrari.StartUP();

            FerrariDriveForwardBtn.Visibility = Visibility.Visible;
            FerrariLaunchControlBtn.Visibility = Visibility.Visible;
            CurrentGearFerrariTXB.Visibility = Visibility.Visible;
            CurrentGearFerrarilbl.Visibility = Visibility.Visible;
            ShiftDownGearFerrari.Visibility = Visibility.Visible;
            ShiftUpGearFerrari.Visibility =Visibility.Visible;


        }
        public void TurnOffCarLambo()
        {
            lamborgini.TurnOFF();
            LamboDriveForwardBtn.Visibility = Visibility.Collapsed;
            LamboLaunchControlBtn.Visibility = Visibility.Collapsed;
            CurrentGearLambolbl.Visibility = Visibility.Collapsed;
            CurrentGearLamboTXB.Visibility = Visibility.Collapsed;
            ShiftUpGearLambo.Visibility = Visibility.Collapsed;
            ShiftDownGearLambo.Visibility = Visibility.Collapsed;
        }
        public void TurnOffCarFerrari()
        {
            ferrari.TurnOFF();
            FerrariDriveForwardBtn.Visibility= Visibility.Collapsed;
            FerrariLaunchControlBtn.Visibility= Visibility.Collapsed;
            CurrentGearFerrariTXB.Visibility = Visibility.Collapsed;
            CurrentGearFerrarilbl.Visibility = Visibility.Collapsed;
            ShiftDownGearFerrari.Visibility = Visibility.Collapsed;
            ShiftUpGearFerrari.Visibility = Visibility.Collapsed;

        }
        private void DriveForwardBtn_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(CarImage, Canvas.GetLeft(CarImage) + 10);
            lamborgini.SpeedUp(20);

        }

        private void LaunchControlBtn_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(CarImage, Canvas.GetLeft(CarImage) + 100);
            lamborgini.SpeedUp(30);

        }
        //how would you make it so you can only Click once 
        private void TurnOnBtn_Click(object sender, RoutedEventArgs e)
        {
            StartUPCarLambo();
        }

        private void TurnOffBtn_Click(object sender, RoutedEventArgs e)
        {
            TurnOffCarLambo();
        }

        private void SwitchCarsBtn_Click(object sender, RoutedEventArgs e)
        {

            Counter++;
            if (Counter % 2 == 0)
            {
                BitmapImage newImage = new BitmapImage();
                newImage.BeginInit();
                newImage.UriSource = new Uri("Images/Lambo2.png", UriKind.Relative);
                newImage.EndInit();
                CarImage.Source = newImage;
                StartUPCarLambo();
                TurnOffCarFerrari();
            }
            else
            {
                BitmapImage newImage = new BitmapImage();
                newImage.BeginInit();
                newImage.UriSource = new Uri("Images/Ferrari.png", UriKind.Relative);
                newImage.EndInit();
                CarImage.Source = newImage;
                StartUpFerrari();
                TurnOffCarLambo();

            }
        }
        #endregion

        #region LaunchCtl&GearBox
        private void FerrariLaunchControlBtn_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(CarImage, Canvas.GetLeft(CarImage) + 100);
            ferrari.SpeedUp(30);
        }

        private void FerrariDriveForwardBtn_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(CarImage, Canvas.GetLeft(CarImage) + 10);
            ferrari.SpeedUp(20);
        }

        //FERRARI
        private void ShiftupFerrari_Click(object sender, RoutedEventArgs e)
        {
            ferrari.transmission.ShiftUp();
            UpdateUI();
        }
        private void ShiftDownFerrari_Click(object sender, RoutedEventArgs e)
        {
            ferrari.transmission.ShiftDown();
            UpdateUI();
        }

       //LAMBO

        private void ShiftupLambo_Click(object sender, RoutedEventArgs e)
        {
            lamborgini.transmission.ShiftUp();
            UpdateUI();
        }

        private void ShiftDownLambo_Click(object sender, RoutedEventArgs e)
        {
            lamborgini.transmission.ShiftDown();
            UpdateUI();
        }
        #endregion

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LamboDriveForwardBtn.Visibility = Visibility.Collapsed;
            LamboLaunchControlBtn.Visibility = Visibility.Collapsed;
            CurrentGearLambolbl.Visibility = Visibility.Collapsed;
            CurrentGearLamboTXB.Visibility = Visibility.Collapsed;
            ShiftUpGearLambo.Visibility = Visibility.Collapsed;
            ShiftDownGearLambo.Visibility = Visibility.Collapsed;
            FerrariDriveForwardBtn.Visibility = Visibility.Collapsed;
            FerrariLaunchControlBtn.Visibility = Visibility.Collapsed;
            CurrentGearFerrariTXB.Visibility = Visibility.Collapsed;
            CurrentGearFerrarilbl.Visibility = Visibility.Collapsed;
            ShiftDownGearFerrari.Visibility = Visibility.Collapsed;
            ShiftUpGearFerrari.Visibility = Visibility.Collapsed;
            UpdateUI();
        }
    }
}