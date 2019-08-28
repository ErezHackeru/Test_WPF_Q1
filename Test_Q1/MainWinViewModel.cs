using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Test_Q1
{
    public class MainWinViewModel
    {
        public DelegateCommand MyDelegate { get; set; }

        public Double Width { get; set; }
        public Double Height { get; set; }
        public string TextOfBtn { get; set; }

        public MainWinViewModel()
        {
            MyDelegate = new DelegateCommand(ExecuteCommand, CanExecuteMethod);            
        }

        // =========================== delegate
        private bool CanExecuteMethod()
        {
            return true;
        }

        private void ExecuteCommand()
        {
            
            ButtonValues BtnValsWin = new ButtonValues(Width, Height, TextOfBtn);
            BtnValsWin.Show();
        }
    }
}
