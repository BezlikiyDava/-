using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Тюрьма
{
    class Судья 
    {
        Solocum Cum;
        public Судья(Solocum C)
        {
            Cum = C;
            MessageBox.Show("Вводите подсудимого");
            Start();
        }

        void Start()
        {
            Cum.wank();
        }
    }
}
