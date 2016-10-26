using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCNDemo
{
    public class ClickHandler
    {
        public ClickHandler()
        {
            Clicks = 0;
        }
        public void Click()
        {
            Clicks++;
        }
        public int Clicks { get; set; }
        public string ClickDescription { get { return $"{Clicks} Clicks"; } }    
    }
}
