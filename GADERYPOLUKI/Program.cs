string gaderypoluki(string clearText)
{   //zapisujemy czysty tekst do przechwytania
    string cypherText = clearText;
    //zamien G na A i zapisz do nowej zmiennej
    cypherText = cypherText.Replace('G', '@');
    // wez jakis czesciowo zaszyfrowany tekst i zamien a na g
    //uzyj znak posredniego aby zapobiec dwukrotnej zmianie jednej litery
    cypherText = cypherText.Replace('A', 'G');
    cypherText = cypherText.Replace('@', 'A');
    // d na e, e na d 
    cypherText = cypherText.Replace('D', '@');
    cypherText = cypherText.Replace('E', 'D');
    cypherText = cypherText.Replace('@', 'E');
    // r na y, y na r
    cypherText = cypherText.Replace('R', '@');
    cypherText = cypherText.Replace('Y', 'R');
    cypherText = cypherText.Replace('@', 'Y');
    // p na o, o na p
    cypherText = cypherText.Replace('P', '@');
    cypherText = cypherText.Replace('O', 'P');
    cypherText = cypherText.Replace('@', 'O');
    //l->u,u->
    cypherText = cypherText.Replace('L', '@');
    cypherText = cypherText.Replace('U', 'L');
    cypherText = cypherText.Replace('@', 'U');
    //k na i, i na k
    cypherText = cypherText.Replace('K', '@');
    cypherText = cypherText.Replace('I', 'K');
    cypherText = cypherText.Replace('@', 'I');

    return cypherText;
}


//tekst do szyfrowania
string cleatText = "GADERY PO LUKI";
//zaszyfruj uzwajac funkcji
string cypherText = gaderypoluki(cleatText);
//zmienna do przechowywania zaszyfrowanego tekstu


Console.WriteLine("Zaszyfrowany tekst: " + cypherText);