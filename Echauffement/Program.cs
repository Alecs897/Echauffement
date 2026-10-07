using System.Diagnostics;

namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré
        Console.WriteLine("Bonjour, je suis Alexander. Mon jeu préféré est genshin impact");

        // Etape 2 : demandez à l'utilisateur son prénom et son âge
        Console.WriteLine("Quel est ton nom ?");
        string firstName = console.ReadLine();

        Console.WriteLine("Quel est ton âge ?");
        int age = Convert.ToInt32(Console.ReadLine());
        
        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur
        bool isUnderage = age < 18;
        if(isUnderage8)
        {
            Console.WriteLine("Tu es mineur.");
        } else
        {
            Console.WriteLine("Tu es majeur.");
        }
        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)
        Console.WriteLine("Combien as-tu d'euro ?");
        infloat money = Convert.ToSingle(Console.ReadLine());

        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix
        Console.WriteLine("\n=== Choix d'armes ===");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4
        Console.WriteLine("Tu peux maintenant choisir l'arme que tu souhaite. Pour cela, encode le chiffre qui correspond à l'arme (1/2/3/4)");
        int weaponChoice = Convert.ToInt32(Console.ReadLine());

        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4
       if(weaponChoice == 1)
       {
            float price = 5.0f;
            if (money < price || isUnderage) // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
            {
                Console.WriteLine("Désolé, tu ne peux pas acheter cette arme.");
            }
            else
            {
                money = money - price; // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
                Console.WriteLine("Félicitation, tu as acheter un couteau !");
            }
       } 
       else if(weaponChoice == 2)
       {
             float price = 15.0f;
            if (money < price || isUnderage) 
            {
                Console.WriteLine("Désolé, tu ne peux pas acheter cette arme.");
            }
            else
            {
                money = money - price;
                Console.WriteLine("Félicitation, tu as acheter une hache !");
            }
       } 
       else if(weaponChoice == 3)
       {
             float price = 30.0f;
            if (money < price || isUnderage)
            {
                Console.WriteLine("Désolé, tu ne peux pas acheter cette arme.");
            }
            else
            {
                money = money - price;
                Console.WriteLine("Félicitation, tu as acheter une lance !");
            }
       } 
       else if(weaponChoice == 4)
       {
            float price = 40.0f;
            if (money < price || isUnderage)
            {
                Console.WriteLine("Désolé, tu ne peux pas acheter cette arme.");
            }
            else
            {
                money = money - price;
                Console.WriteLine("Félicitation, tu as acheter un arc !");
            }
       } 
       else
       {
        Console.WriteLine("Ton choix ne fait pas partie des options disponibles")
       }

          // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible


        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}