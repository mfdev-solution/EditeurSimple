using System;
using System.Windows;
using Microsoft.Win32;
using System.IO;
namespace EditeurFichier
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Nom du fichier à utiliser
        /// </summary>
        private string nomFichier = String.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ouvrir le fichier après la sélection par l'utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoutonOuvrir_Click(object sender, RoutedEventArgs e)
        {
            nomFichier = lireNomFichier();
            if(nomFichier != "")
            {
                string text = EntreesSorties.FiltrerTexte(nomFichier);
                editeur.Text = text;
 
            }
            // TODO - Mettre à jour la méthode BoutonOuvrir_Click 
            // Appel méthode LireNomFichier pour avoir le nom du fichier à charger           
            // Charger la zone de texte de l'éditeur avec le contenu du fichier
        }
        // TODO - Implémenter une méthode pour lire le nom du fichier 
        // Ajouter une méthode LireNomFichier 
        // Enregistrer les données à nouveau dans le fichier
        private void BoutonEnregistrer_Click(object sender, RoutedEventArgs e)
        {
            if (nomFichier != "")
            {
                Console.WriteLine("Message enregistee");
                EntreesSorties.ecrireText(nomFichier, editeur.Text);
                MessageBox.Show("Fichier enregistrer");
            }

            // TODO - Mettre à jour la méthode  BoutonEnregistrer_Click 
            // Enregistrer le contenu de la zone de texte de l'éditeur à nouveau dans le fichier
        }
        private string lireNomFichier()
        {
            string fnom = "";
            OpenFileDialog dlgOuvrirFichier = new OpenFileDialog();
            dlgOuvrirFichier.InitialDirectory = @"C:\Users\Mouhamed_fall";
            dlgOuvrirFichier.DefaultExt = ".txt";
            dlgOuvrirFichier.Filter = "Texte Documents (.txt)|*.txt";
            Boolean openFile = (bool)dlgOuvrirFichier.ShowDialog();
            if (openFile)
            {
                fnom = dlgOuvrirFichier.FileName;
            }

            return fnom;
        }


    }  

}
