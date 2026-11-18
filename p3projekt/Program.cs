class Uczelnia
{
    int IDUczelnii;
    string NazwaUczelni;
    string Adres;
}
class Kierunek : Uczelnia
{
    int IDKierunku;
    string NazwaKierunku;
    int IloscSemestrow;
}
class Wykladowcy : Uczelnia
{
    int IDWykladowcy;
    string ImieWykladowcy;
    string NazwiskoWykladowcy;
}

class Grupy : Kierunek
{
    int IDGrupy;
    int IDKierunky;
    string Grupa;
    int Semestr;
}

class Studenci : Grupy
{
    int IDStudenta;
    int IDGrupy;
    int IDKierunku;
    string ImieStudenta;
    string NazwiskoStudenta;
    int NrIndeksu;
}

