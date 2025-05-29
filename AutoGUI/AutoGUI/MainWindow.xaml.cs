using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AutoGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<Auto> autok = new List<Auto>();
        public MainWindow()
        {
            InitializeComponent();
            LoadFile();



        }
        private void LoadFile()
        {
            try
            {
                string[] lines = File.ReadAllLines(@"..\..\..\src\carsData.csv").Skip(1).ToArray();
                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        autok.Add(new Auto(line));
                    }
                }

                // ✅ Gyártók feltöltése ModellListBox-ba
                var gyartok = autok
                    .Select(a => a.Gyarto.GyartoNev)
                    .Distinct()
                    .OrderBy(n => n)
                    .ToList();
                ModellListBox.ItemsSource = gyartok;
                if (gyartok.Count > 0)
                    ModellListBox.SelectedIndex = 0;

                // ✅ Karosszéria típusok ComboBox
                var karosszeriak = autok
                    .Select(a => a.Karosszeria.KarosszeriaNev)
                    .Distinct()
                    .OrderBy(n => n)
                    .ToList();
                karosszeriaCbx.ItemsSource = karosszeriak;

                // ✅ Váltó típusok ComboBox
                var valtok = autok
                    .Select(a => a.Valto.ValtoNev)
                    .Distinct()
                    .OrderBy(n => n)
                    .ToList();
                GearBoxCBX.ItemsSource = valtok;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading file: {ex.Message}");
            }
        }



        // Example SelectionChanged handler for GyartoListBox


        private void ModellListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ModellListBox.SelectedItem is string selectedGyartoNev)
            {
                var modellek = autok
                    .Where(a => a.Gyarto.GyartoNev == selectedGyartoNev)
                    .Select(a => a.Modell)
                    .Distinct()
                    .OrderBy(m => m)
                    .ToList();

                // Ide írhatod ki például egy másik listába vagy csak tesztelés céljából
                // Példa: MessageBox.Show(string.Join(", ", modellek));
            }

        }

        private void karosszeriaCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var karosszeriak = autok
                .Select(a => a.Karosszeria.KarosszeriaNev)
                .Distinct()
                .OrderBy(n => n)
                .ToList();
            karosszeriaCbx.ItemsSource = karosszeriak;

        }

        private void GearBoxCBX_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var valtok = autok
                .Select(a => a.Valto.ValtoNev)
                .Distinct()
                .OrderBy(n => n)
                .ToList();
            GearBoxCBX.ItemsSource = valtok;
        }
    }

}
