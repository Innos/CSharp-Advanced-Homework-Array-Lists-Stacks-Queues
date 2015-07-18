using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Game
{
    public class OnOpenCellEventArgs : EventArgs
    {
        private int openedCells;

        public OnOpenCellEventArgs(int openedCells)
        {
            this.OpenedCells = openedCells;
        }

        public int OpenedCells 
        {
            get
            {
                return this.openedCells;
            }
            set
            {
                this.openedCells = value;
            } 
        }
    }
}
