using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A18_Ex01_Etai_201506656_Niv_203723622
{
    public class MenuItem
    {
        public ICommand Command { get; set; }

        public virtual void Selected()
        {
            if(Command != null)
            {
                Command.Execute();
            }
        }
    }
}
