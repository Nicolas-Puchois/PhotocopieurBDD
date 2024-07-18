using MCDPhotocopieur.Classes;

void ConsoleMenu()
{
    Console.WriteLine("Que Voulez vous faire?");
    Console.WriteLine("0-- Sortir");
    Console.WriteLine("1-- Creer une entrée");
    Console.WriteLine("2-- Afficher une entrée");
    switch (ChoixMenu())
    {
        case 0:
            Console.WriteLine("Sortie du logiciel");
            break;
        case 1:
            Console.Clear();
            Console.WriteLine("Vous avez choisi de créer un composant");
            CreerComposant();
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Vous avez choisi d'afficher un composant");
           // AfficherComposant();
            break;
        default:
            Console.WriteLine("Erreur la saisie ne correspond pas, veuillez réessayer");
            ChoixMenu();
            break;
    }
}

void CreerComposant()
{
    Console.WriteLine("\n0-- Sortir");
    Console.WriteLine("1-- retour en arriere");
    Console.WriteLine("2-- Creer un Client");
    Console.WriteLine("3-- Creer un Technicien");
    Console.WriteLine("4-- Creer une Imprimante");
    switch (ChoixMenu())
    {
        case 0:
            Console.Clear();
            Console.WriteLine("Sortie du logiciel");
            break;
        case 1:
            Console.Clear();
            Console.WriteLine("Retour en arriere");
            ConsoleMenu();
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Créer un Client");
            CreerClient();
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("Créer un Technicien");
            CreerTechnicien();
            break;
        case 4:
            Console.Clear();
            Console.WriteLine("Créer une imprimante");
            CreerPhotocopieur();
            break;
        default:
            Console.WriteLine("Erreur de la saisie, veuillez réessayer");
            CreerComposant();
            break;
    }
}

Client CreerClient()
{
    string nom;
    string prenom;
    string ville;
    string rue;
    int    numeroRue;
    int    telephone;

    Console.Write("Entrer le prénom : ");
    prenom = Console.ReadLine();
    Console.Write("Entrer le nom : ");
    nom = Console.ReadLine();
    Console.Write("Entrer la ville :");
    ville = Console.ReadLine();
    Console.Write("Entrer la rue :");
    rue = Console.ReadLine();
    Console.Write("Entrer le numero de porte :");
    numeroRue = int.Parse(Console.ReadLine());
    Console.Write("Entrer le numero de téléphone :");
    telephone = int.Parse(Console.ReadLine());

    Client ClientCreation = new Client(numeroRue, telephone, ville, rue, nom, prenom);
    Console.Clear();
    Console.Write($" nom : {ClientCreation.Nom} " +
                  $" prenom : {ClientCreation.Prenom} " +
                  $" ville : {ClientCreation.Ville} " +
                  $" rue : {ClientCreation.Rue} " +
                  $" porte : {ClientCreation.NumeroAdresse} " +
                  $" téléphone : {ClientCreation.NumeroTelephone} ");
    CreerComposant();
    return ClientCreation;
}

Technicien CreerTechnicien()
{
    string prenomTechnicien;
    string nomTechnicien;
    string villeAttitre;
    int    telephone;


    Console.Write("Entrer le prénom : ");
    prenomTechnicien = Console.ReadLine();
    Console.Write("Entrer le nom : ");
    nomTechnicien = Console.ReadLine();
    Console.Write("Entrer la ville attitré : ");
    villeAttitre = Console.ReadLine();
    Console.Write("Entrer le téléphone : ");  
    telephone = int.Parse(Console.ReadLine());

    Technicien TechnicienCreation = new Technicien (telephone, prenomTechnicien, nomTechnicien, villeAttitre);
    Console.Clear();
    Console.Write($"id : {TechnicienCreation.Id_Technicien}" +
                  $"prenom : {TechnicienCreation.Prenom} " +
                  $"nom : {TechnicienCreation.Nom} " +
                  $"ville attitré : {TechnicienCreation.VilleAttitre}" +
                  $"{TechnicienCreation.Telephone_Tech}");
    CreerComposant();
    return TechnicienCreation;
}
Photocopieur CreerPhotocopieur()
{
    string modele;
    int anneeConstruction;


    Console.Write("Entrer le modèle : ");
    modele = Console.ReadLine();
    Console.Write("Entrer l'année de construction : ");
    anneeConstruction = int.Parse(Console.ReadLine());

    Photocopieur PhotocopieurCreation = new Photocopieur(modele, anneeConstruction);
    Console.Clear();
    Console.Write($"id :                 {PhotocopieurCreation.IdPhotocopieur}" +
                  $"modele :             {PhotocopieurCreation.Modele} + " +
                  $"année construction : {PhotocopieurCreation.AnneeConstruction}");
    CreerComposant();
    return PhotocopieurCreation;
}
int ChoixMenu()
{
    int choixOperateur;
    bool isChoixValid;
    isChoixValid = false;
    choixOperateur = 0;
    while (!isChoixValid)
    {
        isChoixValid = Int32.TryParse(Console.ReadLine(), out choixOperateur);

        if (isChoixValid == false)
        {
            Console.WriteLine("Erreur de la saisie, veuillez réessayer");
        }
    }
    return choixOperateur;
}

ConsoleMenu();
