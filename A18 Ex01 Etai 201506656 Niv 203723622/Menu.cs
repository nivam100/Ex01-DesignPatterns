using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A18_Ex01_Etai_201506656_Niv_203723622
{
    public class Menu : List<MenuItem>
    {
        public void Run(int i_choice)
        {
            this[i_choice].Selected(); 
        }
    }
}
