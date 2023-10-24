using Evaluation24_10_2023;


Client signataire = new Client();
signataire.name = "Torrenti";
signataire.prenom = "Sylvain";
Client signataire2 = new Client();
signataire2.name = "Toto";
signataire2.prenom = "Tartenpion";
Client client = new Client();
#region test compte epargne
//Avec solde initial suffisant
CompteEpargne compteEpargne = new(1000, client, 50000, 2.6);
Console.WriteLine(compteEpargne.solde);
//Avec solde initiale non suffisant
CompteEpargne compteEpargne2 = new(1000, client, 500, 2.6);

Console.WriteLine("!!!!!DEBITER!!!!!");
compteEpargne.debiter(40000);
compteEpargne.debiter(20000);
#endregion
Console.WriteLine("----------------------------------");
#region compte courant
CompteCourant compteCourant = new(client, signataire, 15000, 500);
compteCourant.debiter(14000);
Console.WriteLine("il y a comme signataire :");
foreach (var clientSignataire in compteCourant.signataires)
{
    Console.WriteLine(clientSignataire.name + " " + clientSignataire.prenom);
}
Console.WriteLine("+++++++++++++");
compteCourant.addSignataire(signataire2);
Console.WriteLine("il y a comme signataire :");
foreach (var clientSignataire in compteCourant.signataires)
{
    Console.WriteLine(clientSignataire.name + " " + clientSignataire.prenom);
}
#endregion
