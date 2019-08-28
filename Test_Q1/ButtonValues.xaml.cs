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
using System.Windows.Shapes;

namespace Test_Q1
{
    /// <summary>
    /// Interaction logic for ButtonValues.xaml
    /// </summary>
    public partial class ButtonValues : Window
    {
        
        public ButtonValues(Double Width, Double Height, string TextOfBtn)
        {
            InitializeComponent();
            
            WidthPresentor.DataContext = Width;
            HeightPresentor.DataContext = Height;
            TextPresentor.DataContext = TextOfBtn;            
        }
        
        
    }
}
