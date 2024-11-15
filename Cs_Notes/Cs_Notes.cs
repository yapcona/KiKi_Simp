// csharp hat neben int noch decimal für kommazahlen
decimal randomNumber = 7.9;

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

/*
Hauptversion (2.0.0): Ich möchte Updates auf die neueste Hauptversion durchführen, sobald diese verfügbar ist. Ich akzeptiere die Tatsache, dass ich möglicherweise meinen Code ändern muss.
Nebenversion (1.2.0): Es ist akzeptabel, dass ein neues Feature hinzugefügt wird. Ich möchte keine Breaking Changes für meinen Code.
Patchversion (1.0.1): Nur Fehlerbehebungen sind akzeptabel.
*/

/*

Lokale Variablen sind innerhalb des aktuellen Kontext referenzierbar (in der Regel Innerhalb der aktuellen Funktion).
Auf globale Variablen kann von überall in Ihrem Programm aus zugegriffen werden. Dazu gehören auch Systemobjekte aus der JavaScript-Runtime. Aus diesme Grund werden unter Umschönden sehr viele Elemente in diesem Abschnitt angezeigt.
Closure-Variablen sind Variablen, auf die nur innerhalb der akteullen Closure zugegriggen werden kann (sofern vorahenden). Eine Closure kombiniert denlokalen Gelungsbereich einer Funktion mir dem Geltungbereich der äußeren Funktion, zu der sie gehört.

*/
