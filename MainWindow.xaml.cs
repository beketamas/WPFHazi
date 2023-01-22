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

namespace HaziFeladat
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

		private void btnOsszead_Click(object sender, RoutedEventArgs e)
		{
			String eredmeny = $"{txtAszam.Text}+{txtBszam.Text} = {Convert.ToDouble(txtAszam.Text) + Convert.ToDouble(txtBszam.Text)}";
			MessageBox.Show("Az összeadás eredménye:"+eredmeny);
			lbEredmenyek.Items.Add(eredmeny);
		}

		private void btnKivon_Click(object sender, RoutedEventArgs e)
		{
			String eredmeny = $"{txtAszam.Text}-{txtBszam.Text} =  {Convert.ToDouble(txtAszam.Text) - Convert.ToDouble(txtBszam.Text)}";
			MessageBox.Show("Az kivonás eredménye:" + eredmeny);
			lbEredmenyek.Items.Add(eredmeny);
		}

		private void btnSzoroz_Click(object sender, RoutedEventArgs e)
		{
			String eredmeny = $"{txtAszam.Text}*{txtBszam.Text} = {Convert.ToDouble(txtAszam.Text) * Convert.ToDouble(txtBszam.Text)}";
			MessageBox.Show("Az szorzás eredménye:" + eredmeny);
			lbEredmenyek.Items.Add(eredmeny);
		}

		private void btnOszt_Click(object sender, RoutedEventArgs e)
		{
			if (Convert.ToDouble(txtBszam.Text) == 0)
			{
				MessageBox.Show("0-val nem osztunk");
			}
			else
			{
				String eredmeny = $"{txtAszam.Text}/{txtBszam.Text} = {Convert.ToDouble(txtAszam.Text) / Convert.ToDouble(txtBszam.Text)}";
				MessageBox.Show("Az osztás eredménye:" + eredmeny);
				lbEredmenyek.Items.Add(eredmeny);
			}
		}
	}
}
