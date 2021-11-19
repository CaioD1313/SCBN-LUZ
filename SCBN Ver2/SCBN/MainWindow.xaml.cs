using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SCBN
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>



    public partial class MainWindow : Window
    {









        public MainWindow()
        {
            
            InitializeComponent();
            DataContext = new MainWindowsVM();

        }


   

        

        private void OBremove_Click(object sender, RoutedEventArgs e)
        {
            //desabilita o botao de remoção e habilita os outros botoes
            OBcadastro.IsEnabled = true;
            OBremove.IsEnabled = false;
            OBconsulta.IsEnabled = true;


            //Torna a Opção de Remoção Visivel
            removeTitle.Visibility = Visibility.Visible;

            //Torna as outras opões invisiveis
            insertTitle.Visibility = Visibility.Hidden;
            consultTitle.Visibility = Visibility.Hidden;

            titlebox.Text = "";
            authorbox.Text = "";
            doibox.Text = "";


            if (lvremove.Items.IsEmpty)
            {


                Rcadastro.IsEnabled = false;

                MessageBox.Show("A lista de títulos está vazia. Adicione items à lista para que possa remove-los, quando necessário.");

                
            }

            else { Rcadastro.IsEnabled = true; }

        }

        private void OBconsulta_Click(object sender, RoutedEventArgs e)
        {

            //desabilita o botao de remoção e habilita os outros botoes
            OBcadastro.IsEnabled = true;
            OBremove.IsEnabled = true;
            OBconsulta.IsEnabled = false;


            //Torna a Opção de Remoção Visivel
            consultTitle.Visibility = Visibility.Visible;

            //Torna as outras opões invisiveis
            insertTitle.Visibility = Visibility.Hidden;
            removeTitle.Visibility = Visibility.Hidden;


            titlebox.Text = "";
            authorbox.Text = "";
            doibox.Text = "";

        }

        private void OBreset_Click(object sender, RoutedEventArgs e)
        {
            //Reseta cond. inicial dos botoes
            OBcadastro.IsEnabled = true;
            OBremove.IsEnabled = true;
            OBconsulta.IsEnabled = true;


            //Reseta cond. inicial dos groupboxs das opts.
            consultTitle.Visibility = Visibility.Hidden;
            insertTitle.Visibility = Visibility.Hidden;
            removeTitle.Visibility = Visibility.Hidden;

            titlebox.Text = "";
            authorbox.Text = "";
            doibox.Text = "";

        }

        private void Bcadastro_Click(object sender, RoutedEventArgs e)


        {

            


            if (titlebox.Text == "" || authorbox.Text == "" || doibox.Text == "")
            {

                
               
                MessageBox.Show("Você deve preencher todos os campos para realizar o cadastro!");
                cad.Content = "0"; // não deixa cadastrar  sem preencher todas as Text Boxes
                


            }

            else
            {
                cad.Content = "1"; // deixa cadastrar
               
                MessageBox.Show("Livro cadastrado com sucesso!");
                
               

                //como houve sucesso, limpa os campos de cadastro
                titlebox.Text = "";
                authorbox.Text ="";
                doibox.Text = "";
            }

           
        }

        private void Rcadastro_Click(object sender, RoutedEventArgs e)
        {


            int i = lvremove.SelectedIndex;
            del.Content = i.ToString();

            int h = lvremove.Items.Count;
            

            // MessageBox.Show(i + "");
            MessageBox.Show("Título removido com sucesso");


            if (lvremove.Items.IsEmpty || h == 1 )
            {


                Rcadastro.IsEnabled = false;

                //MessageBox.Show("A lista de títulos está vazia. Adicione items à lista para que possa remove-los, quando necessário.");


            }

            else { Rcadastro.IsEnabled = true; }

            titlebox.Text = "";
            authorbox.Text = "";
            doibox.Text = "";


        }

        
        private void Bconsulta_Click(object sender, RoutedEventArgs e)
        {
            int k = titleselect.SelectedIndex;

            tdisp.Content = k.ToString();

            MessageBox.Show(k+"");
        }

        private void OBcadastro_Click(object sender, RoutedEventArgs e)
        {
            //desabilita o botao de cadastro e habilita os outros botoes
            // OBcadastro.IsEnabled = false;
            OBremove.IsEnabled = true;
            OBconsulta.IsEnabled = true;


            //Torna a Opção de Cadastro Visivel
           // insertTitle.Visibility = Visibility.Visible;

            //Torna as outras opões invisiveis
            removeTitle.Visibility = Visibility.Hidden;
            consultTitle.Visibility = Visibility.Hidden;


        }
    }
}
