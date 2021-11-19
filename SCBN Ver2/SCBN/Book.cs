using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SCBN
{
    public class Book  { 

        //instance variables

        //public string livro;

        public string livro { get; set; }

        public string autor { get; set; }

        public string info;

        //// properties



         public string Livro {

            get { return livro; }

            set { 
                
               // if(value!= this.livro)
               // {
                    livro = value;
                    //NotifyPropertyChanged("Livro");


                //}
                 
            
            
            }

         }


        //public string Autor {

        //    get { return autor; }

        //    set { autor = value; }

        //}


        //public string Info {

        //    get { return info; }

        //    set { info = value; }

        //    }


        //métodos (a adicionar)

       


        //Construtor:

        public Book() {


           // ObservableCollection<string> livro = new ObservableCollection<string>();

        }


        





    }


}

