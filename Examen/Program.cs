using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Examen
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        //------------------------La classe Etudiant----------------------------------       
        public class Etudiant
        {
            private int Num_Etudiant;
            private string Nom;
            private string Prenom;
            private string Filiere;
            private string option;

            public Etudiant()
            {
                Console.WriteLine("Constructeur par defaut est appelé");
            }
            public Etudiant(int Num_Etudiant, string Nom, string Prenom, string Filiere, string option)
            {
                this.Num_Etudiant = Num_Etudiant;
                this.Nom = Nom;
                this.Prenom = Prenom;
                this.Filiere = Filiere;
                this.option = option;
            }

            public void setNum(int NumberE)
            {
                Num_Etudiant = NumberE;
            }

            public int getNum()
            {
                return Num_Etudiant;
            }
            public void setNom(string Nom)
            {
                this.Nom = Nom;
            }

            public string getNom()
            {
                return Nom;
            }
            public void setPrenom(string Prenom)
            {
                this.Prenom = Prenom;
            }

            public string getPrenom()
            {
                return Prenom;
            }

            public void setFiliere(string filiere)
            {
                this.Filiere = filiere;
            }

            public string getFiliere()
            {
                return Filiere;
            }
            public void setOption(string option)
            {
                this.option = option;
            }

            public string getOption()
            {
                return option;

            }

        }
//---------------------------------------------La fin de la classe Etudiant -----------------------------------

//---------------------------------------------La classe Evaluation ------------------------------------
         public class Evaluation
         {
                protected string Matiere;
                protected int Date_Debut;
                protected int Date_Fin;

                protected Evaluation()
                {
                   Console.WriteLine("Constructeur par defaut est appelé");
                }
                protected Evaluation(string matiere, int date_Debut, int date_Fin)
                {
                    Matiere = matiere;
                    Date_Debut = date_Debut;
                    Date_Fin = date_Fin;
                }

            public void setMatiere(string Matiere)
                {
                    this.Matiere = Matiere;
                }

                public string getMatiere()
                {
                    return Matiere;
                }

                public void setDate_Debut(int D_Debut)
                {
                    this.Date_Debut = D_Debut;
                }

                public int getDate_Debut()
                {
                    return Date_Debut;
                }

                public void setDate_Fin(int D_Fin)
                {
                    this.Date_Fin = D_Fin;
                }

                public int getDate_Fin()
                {
                    return Date_Fin;
                }

                public Etudiant Info() //association de composition
                {
                    Etudiant Et = new Etudiant();

                    return Et;
                }
         }
//--------------------------------Fin de la Classe Evaluation-----------------------------------
         
//--------------------------------La classe Exercice ----------------------------------------------
         public class Exercice:Evaluation
         {
            private int NB_Exercice;

            public Exercice()
            {
                Console.WriteLine("Constructeur par defaut est appelé");
            }
            public int get_NB_Exercice()
            {
                return NB_Exercice;
            }
            public void set_NB_Exercice(int nb)
            {
                NB_Exercice = nb;
            }
         }
 //-------------------------------Fin de la classe Exercice-----------------------------------------------

 //---------------------------------Classe QCM------------------------------------------------------------
         public class QCM : Evaluation
        {
            private int NB_Itteration;
            public QCM()
            {
                Console.WriteLine("Constructeur par defaut est appelé");
            }
            public int get_NB_Itteration()
            {
                return NB_Itteration;
            }
            public void set_NB_Exercice(int nb)
            {
                NB_Itteration = nb;
            }

           
         }
//-------------------------------------Classe Question -------------------------------------------
         public class Question
         {
            private int NB_Question;
            private int Note_Question;

            public Question()
            {
                Console.WriteLine("Constructeur par defaut est appelé");
            }
            public Question(int nB_Question, int note_Question)
            {
                NB_Question = nB_Question;
                Note_Question = note_Question;
            }
            public int get_NB_Question()
            {
                return NB_Question;
            }
            public void set_NB_Exercice(int nb)
            {
                NB_Question = nb;
            }

            public Exercice exercice() //association de composition
           {
               Exercice Ex = new Exercice();

               return Ex;
           }

            public QCM qcm() //association de composition
            {
                QCM Q = new QCM();

                return Q;
            }

         }
//---------------------------------Fin de la classe Question ------------------------------------

    }
}
