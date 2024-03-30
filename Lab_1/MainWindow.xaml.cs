using System;
using System.Collections.Generic;
using System.Data;
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
using Lab_1.TEREMOKDataSetTableAdapters;

namespace Lab_1
{
    public partial class MainWindow : Window
    {
        BLINITableAdapter blin = new BLINITableAdapter();

        public MainWindow()
        {
            InitializeComponent();
            TeremokGrid.ItemsSource = blin.GetData();
        }
        private void TeremokGrid_SelectionChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object cell = (TeremokGrid.SelectedItem as DataRowView).Row[1];
            MessageBox.Show(cell.ToString());
        }
    }
}

