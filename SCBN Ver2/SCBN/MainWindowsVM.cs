using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SCBN
{
    public class MainWindowsVM : INotifyPropertyChanged
    {
        //Var public para add títulos e autor na lista combobox
        public ObservableCollection<Book> booklist { get; set; }


        //cria var comando para os buttons inside
        public ICommand actionOB1 { get; private set; }

        public ICommand actionOB2 { get; private set; }

        public ICommand actionOB3 { get; private set; }

        //cria var comando para os buttons outside
        public ICommand EnterOB1 { get; set; }

        public ICommand EnterOB2 { get; private set; }

        public ICommand EnterOB3 { get; private set; }

        public ICommand ResetOB { get; private set; }

        /************************************************
         ************************************************
         ******************* Opt 1 **********************
         ************************************************
         ************************************************/

        //var binding com IsEnabled dos buttons outside


        private bool EnableEOB1 = true;// Começa o programa com EnterOB1 habilitado

        //var binding com Visibility dos GroupBoxes
        public string VisibilityGB1 { get; set; } = "Hidden";// Começa o programa com EnterOB1 habilitado

        // var para o textbox - título
        public string Btitle { get; set; }

        

        // var para o textbox - autor
        public string Bauthor { get; set; }

        // var text box consulta disp.
        public string Bdoi { get; set; }

        // var text block consulta disp.
        public string Bdisp { get; set; }

        // var content label del.
        public string deleta { get; set; }

        public string delta { get; set; }

        public int listindex { get; set; }

        public int comboindex { get; set; }

        // var content label testa condição de cadastro
        public string cadastra { get; set; }

        // var content label disp. info 
        public string mostra { get; set; }




        /************************************************
         ******************** FIM ***********************
         ******************* Opt 1 **********************
         ************************************************
         ************************************************/



        public MainWindowsVM()
         {



             //Book BookCadastro = new Book();

            booklist = new ObservableCollection<Book>();

            // booklist = new List<Book>();    

            //Book booklist = new ObservableCollection<Book>();






            /************** BOTAO Entra Cadastro ****************/

            // booklist = new ObservableCollection<string>();


            //Notifica(cadastra);
            //int ins = Convert.ToInt32(cadastra);
            //EnableButtons CEnableOB1 = new EnableButtons();

            //lambda function para o comando do botao
            EnterOB1 = new RelayCommand((object nope) =>
            {
             
                //CEnableOB1.classEnableEOB1 = "false"; 
               // EnableEOB1 = "false";
                VisibilityGB1 = "Visible";
               // Notifica(EnableEOB1);
                Notifica(VisibilityGB1);
                //NotifyPropertyChanged();
                //NotifyPropertyChanged(EnableEOB1);
                EnableEOB1 = false;

               //EnableEOB1 = EnableEOB1 ? false: true;

            }, (object nope) =>
            {
                
                return EnableEOB1;

            });



            /*** FIM  ******* Botao Entra Cadastro**************/







            /************** BOTAO de Cadastro****************/

            // booklist = new ObservableCollection<string>();


            //Notifica(cadastra);
            //int ins = Convert.ToInt32(cadastra);


            //lambda function para o comando do botao
            actionOB1 = new RelayCommand((object nope) =>
                {

                    Book BookCadastro = new Book();
                    BookCadastro.livro = Btitle;
                    BookCadastro.autor = Bauthor;
                    BookCadastro.info = Bdoi;

                    booklist.Add(BookCadastro);
                    


                    
                    //Notifica(Btitle);
                   // Notifica(Bauthor);
                   // Notifica(Bdoi);





                });

                

            /*** FIM  ******* BOTAO de Cadastro**************/


            /************** BOTAO de Remoção****************/

           // booklist = new ObservableCollection<string>();




            //lambda function para o comando do botao
            actionOB2 = new RelayCommand((object nope) =>
            {
                

                try{
                   

                    booklist.RemoveAt(listindex);
                    //booklist.RemoveAt(Convert.ToInt16(deleta));
                   // displist.RemoveAt(Convert.ToInt16(deleta));
                    
                    
                    
                }

                catch

                {;}
                




            });

            /*** FIM  ******* BOTAO de Remoção******************/




            /****************************************/


            //lambda function para o comando do botao
            actionOB3 = new RelayCommand((object nope) =>
            {


                //Bdisp = displist[Convert.ToInt16(mostra)];
                //Bdisp = displist.ElementAt(Convert.ToInt16(mostra));
                try
                {
                    Bdisp = booklist[comboindex].info;
                    Notifica(Bdisp);

                }
                catch {; }
            });


            /***************************************/







        }


        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.  
        // The CallerMemberName attribute that is applied to the optional propertyName  
        // parameter causes the property name of the caller to be substituted as an argument.  
        private void Notifica(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        // private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        // {
        //      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        // }



        // private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        //  {
        //     if (PropertyChanged != null)
        //     {
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //    }
        // }

      //  private void NotifyPropertyChanged(String propertyName)
      //  {
      //      PropertyChangedEventHandler handler = PropertyChanged;
     //       if (null != handler)
       //     {
      //          handler(this, new PropertyChangedEventArgs(propertyName));
      //      }
      //  }




    }



}



    

