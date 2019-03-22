using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConsumoListaApp
{
    public partial class MainPage : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Dictionary<string, string> conteudo = new Dictionary<string, string>();
            conteudo.Add("Professor", "Ramon");
            conteudo.Add("Aluno", "Michael");
            conteudo.Add("Mito", "Lula");
            conteudo.Add("Oraculo", "Dilma");

            var listaItens = conteudo.Keys.ToList();
            ArrayList lista = new ArrayList();
            for (int i=0; i < listaItens.Count; i++)
            {
                if (listaItens[i].Contains("Oraculo"))
                {
                    lista.Add(listaItens[i]);
                }

            }
            listaMunicipio.ItemsSource = lista;
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
