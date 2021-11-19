using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SCBN
{
    public class EnableButtons : INotifyPropertyChanged

    {

        public string classEnableEOB1 { get; set; }


        public string ClassEnableEOB1
        {
            get { return classEnableEOB1; }
            
            set
            {
                classEnableEOB1 = value;
                NotifyPropertyChanged(ClassEnableEOB1);
            }
        }


        // Property Change Logic  
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
 


    

