using System.Windows;

namespace RollerCoaster
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

        private void button_Click(object sender, RoutedEventArgs e)
        {


            // datatyp   namn   eventuellt ge den ett värde
            int dinLängd = 0;
            int dinÅlder = 0;
            int längdGräns = 120, åldersGräns = 7;


            dinLängd = int.Parse(txtLängd.Text);
            dinÅlder = int.Parse(txtÅlder.Text);

            // får Lisa åka i Flygis
            // ja det får hon om hon är minst 90 cm lång!

            if (dinLängd > längdGräns && dinÅlder > åldersGräns)
            {
                // säg ja
                // " --> får genom att trycka tangenten shift + 2
                MessageBox.Show("Ja");
            }
            else
            {
                // säg nej
                MessageBox.Show("Nej");
            }


            // om personen är mellan 0 och 89 cm
            // då får hen åka saker "alla kan åka"

            // men är personen 90 - 109
            // får bland annat åka flygis
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            int längd = 120;
            string meddelande = "Du får åka "; // som 0 för int. 
            // hur många får jag åka?
            int totalaAntaletKarusellerJagFårÅka = RäknaAntalTillåtna(längd);

            // två gånger
            // först hur många

            // banan
            // banan och kiwi
            // banan, kiwi och citron
            // vilka

            // småbarn
            // tekopp  småbarn, tekopp och elefant
            // elefant
            meddelande = VilkaKarusellerFårJagÅka(längd);
            MessageBox.Show(meddelande);
            string name = "James Bond";
        }
        private string VilkaKarusellerFårJagÅka(int längd)
        {
            string meddelande = "Du får åka ";
            int antalTillåtna = RäknaAntalTillåtna(längd);
            if (längd > 50)
            {
                meddelande += "Småbarnens karusell";
            }
            if (längd >= 90)
            {
                // "Småbarnens karusell, snurrande tekoppar"
                if (antalTillåtna == 2)
                {
                    meddelande += " och snurrande tekoppar";
                }
                else
                {
                    meddelande += ", snurrande tekoppar";
                }
            }
            if (längd >= 110)
            {
                if (antalTillåtna == 3)
                {
                    meddelande += " och ";
                }
                else
                {
                    meddelande += ", ";
                }
                meddelande += "Flygande elefanter";
            }
            if (längd >= 130)
            {
                meddelande += " och Lilla Berg-och-dalbanan!";
            }
            else if (längd >= 140)
            {
                meddelande = "Du får åka alla attraktioner!";
            }
            return meddelande;
        }
        private int RäknaAntalTillåtna(int längd)
        {
            int antal = 0;
            if (längd > 50)
            {
                antal++;
            }
            if (längd >= 90)
            {
                antal++;
            }
            if (längd >= 110)
            {
                antal++;

            }
            if (längd >= 130)
            {
                antal++;

            }
            if (längd >= 140)
            {
                antal++;
            }

            return antal;
        }
    }
}