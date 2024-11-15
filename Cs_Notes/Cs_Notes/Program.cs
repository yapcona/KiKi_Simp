// csharp hat neben int noch decimal für kommazahlen
// decimal randomNumber = 7.9;

/* Zeichenfolgeninterpolation in C# bedeutet, 
dass du Variablen direkt in einen String einfügen kannst, 
ohne mühsam Verkettungen mit dem Pluszeichen (+) zu verwenden. 
Stattdessen nutzt du das Dollarzeichen ($) vor einem String,
um den Inhalt von Variablen oder Ausdrücken innerhalb von geschweiften Klammern ({}) in den String einzubauen.
*/

int age = 25;
string name = "Selda";

string whatsPoppinG = $"Hey was laeuft was laeuft. Ich bin {name} und {age} alt.";
Console.WriteLine(whatsPoppinG);


