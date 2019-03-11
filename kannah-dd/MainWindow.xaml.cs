using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
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

namespace kannah_dd
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        List<LangItem> languages { get; set; } = new List<LangItem>();
        public MainWindow()
        {
            InitializeComponent();
            this.Title = Assembly.GetExecutingAssembly().GetName().Name;
            this.languages.Add(new LangItem()
            {
                name = "Angular"
            });
            this.DataContext = this;
        }

    }
    internal class LangItem
    {
        internal string name { get; set; }
    }
}
