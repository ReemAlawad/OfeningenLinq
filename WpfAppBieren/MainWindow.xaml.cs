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
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using BierenLibrary;

namespace WpfAppBieren
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BierenService service;
        public MainWindow()
        {
            InitializeComponent();
            service = new BierenService();
        }

        private void BtnSelectBieren_Click(object sender, RoutedEventArgs e)
        {
           List<Bier> bierenMetMeerDan7Alcohol = service.Bieren.Where(bier => bier.Alcohol > 7).ToList();
            List<string> displayTexts = bierenMetMeerDan7Alcohol.Select(bier => $"{bier.Naam}:{bier.Alcohol:F2}%").ToList();
            ResultListBox.ItemsSource = displayTexts;
        }

        private void BtnSelectBierenFromJupiler_Click(object sender, RoutedEventArgs e)
        {
            List<Bier> bierenVanJupilerLagerDan5Alcohol = service.Bieren.Where(bier => bier.Brouwer.ToLower() == "jupiler" && bier.Alcohol <= 5).ToList();
            List<string> displayTexts = bierenVanJupilerLagerDan5Alcohol.Select(bier => $"{bier.Naam}:{bier.Alcohol:F2}%").ToList();
            ResultListBox.ItemsSource = displayTexts;
        }

        private void BtnSelectBierenWithDelhaize_Click(object sender, RoutedEventArgs e)
        {
            List<Bier> bierenMetDelhaizeInBrouwerNaam = service.Bieren.Where(bier => bier.Brouwer.ToLower().Contains("delhaize")).ToList();
            List<string> displayTexts = bierenMetDelhaizeInBrouwerNaam.Select(bier => $"{bier.Naam} - {bier.Brouwer}:{bier.Alcohol:F2}%").ToList();
            ResultListBox.ItemsSource = displayTexts;
        }

        private void BtnSelectBierByBierNr_Click(object sender, RoutedEventArgs e)
        {
            var bierNr120 = service.Bieren.Where(bier => bier.BierNr == 120);
            List<string> displayTexts = bierNr120.Select(bier => $"{bier.Naam}: {bier.Brouwer} :{bier.BierNr}").ToList();
            ResultListBox.ItemsSource = displayTexts;
        }

        private void BtnSelectBierenFromSpecificBrouwers_Click(object sender, RoutedEventArgs e)
        {
            List<Bier> bierenVanSpecifiekeBrouwers = service.Bieren.Where(bier => bier.Brouwer.ToLower() == "jupiler" || bier.Brouwer.ToLower() =="palm" || bier.Brouwer.ToLower() =="artois").OrderBy(bier => bier.Brouwer).ToList();
            List<string> displayTexts = bierenVanSpecifiekeBrouwers.Select(item => $"{item.Brouwer}:{item.Naam}").ToList();
            ResultListBox.ItemsSource = displayTexts;
        }

        private void BtnCalculateAverageAlcoholByBrouwer_Click(object sender, RoutedEventArgs e)
        {
            var gemiddeldeAlcoholPerBrouwer = service.Bieren.GroupBy(bier => bier.Brouwer.ToLower()).Select(group => new {Brouwer = group.Key, GemiddeldeAlcohol = group.Average(bier => bier.Alcohol)}).OrderByDescending(result => result.GemiddeldeAlcohol).ToList();
            List<string> displayTexts = gemiddeldeAlcoholPerBrouwer.Select(item => $"{item.Brouwer}:{item.GemiddeldeAlcohol:F2}%").ToList();
            ResultListBox.ItemsSource = displayTexts;
        }
    }
}