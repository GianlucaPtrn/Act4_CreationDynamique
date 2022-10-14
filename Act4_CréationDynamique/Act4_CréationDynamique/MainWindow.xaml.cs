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

namespace Act4_CréationDynamique
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            affichageWpf();
        }

        public void affichageWpf()
        {
            //Définition de colonne et ligne 
            ColumnDefinition coldef1 = new ColumnDefinition();
            ColumnDefinition coldef2 = new ColumnDefinition();
            ColumnDefinition coldef3 = new ColumnDefinition();
            GrdMain.ColumnDefinitions.Add(coldef1);
            GrdMain.ColumnDefinitions.Add(coldef2);
            GrdMain.ColumnDefinitions.Add(coldef3);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            GrdMain.RowDefinitions.Add(rowDef1);
            GrdMain.RowDefinitions.Add(rowDef2);
            GrdMain.RowDefinitions.Add(rowDef3);

            //TextBlock
            TextBlock txtB1 = new TextBlock();
            txtB1.Text = "TextBlock créer dynamiquement";
            txtB1.Foreground = Brushes.Red;
            txtB1.Background = Brushes.Yellow;
            txtB1.FontSize = 20;
            txtB1.FontFamily = new FontFamily("Times New Roman");
            txtB1.Height = 40;
            Grid.SetColumnSpan(txtB1, 3);
            Grid.SetColumn(txtB1, 0);
            GrdMain.Children.Add(txtB1);

            //boutton1,2,3
            Button btnB1 = new Button();
            Button btnB2 = new Button();
            Button btnB3 = new Button();
            btnB1.Height = 150;
            btnB1.Width = 150;
            btnB1.VerticalAlignment = VerticalAlignment.Center;
            btnB1.HorizontalAlignment = HorizontalAlignment.Center;
            btnB1.Content = "Boutton 1";
            btnB2.Height = 150;
            btnB2.Width = 150;
            btnB2.VerticalAlignment = VerticalAlignment.Center;
            btnB2.HorizontalAlignment = HorizontalAlignment.Center;
            btnB2.Content = "Boutton 2";
            btnB3.Height = 150;
            btnB3.Width = 150;
            btnB3.VerticalAlignment = VerticalAlignment.Center;
            btnB3.HorizontalAlignment = HorizontalAlignment.Center;
            btnB3.Content = "Boutton 3";
            Grid.SetColumn(btnB1, 0);
            Grid.SetRow(btnB1, 1);
            Grid.SetColumn(btnB2, 1);
            Grid.SetRow(btnB2, 1);
            Grid.SetColumn(btnB3, 2);
            Grid.SetRow(btnB3, 1);
            GrdMain.Children.Add(btnB1);
            GrdMain.Children.Add(btnB2);
            GrdMain.Children.Add(btnB3);

            //StackPanel
            StackPanel stkPanel1 = new StackPanel();
            Grid.SetColumnSpan(stkPanel1, 2);
            Grid.SetRow(stkPanel1, 2);
            stkPanel1.Height = 150;
            GrdMain.Children.Add(stkPanel1);
            
            //TextBox dans le stackPanel
            TextBox txtBox1 = new TextBox();
            txtBox1.VerticalAlignment = VerticalAlignment.Bottom;
            txtBox1.Background = Brushes.Yellow;
            txtBox1.Text = "Info :";
            Grid.SetColumnSpan(txtBox1, 2);
            Grid.SetRow(txtBox1, 2);
            txtBox1.Height = 45;
            stkPanel1.Children.Add(txtBox1);

            //TextBlock dans le StackPanel
            TextBlock txtB2 = new TextBlock();
            Grid.SetColumnSpan(txtB2, 2);
            Grid.SetRow(txtB2, 2);
            txtB2.Height = 40;
            txtB2.Text = "J'attends vos info";
            stkPanel1.Children.Add(txtB2);

            //ComboBox
            ComboBox cmbBox = new ComboBox();
            cmbBox.Items.Add("Dorian");
            cmbBox.Items.Add("Gianluca");
            Grid.SetColumn(cmbBox, 2);
            Grid.SetRow(cmbBox, 2);
            cmbBox.Height = 75;
            cmbBox.Width = 150;
            GrdMain.Children.Add(cmbBox);

        }
    }
}
