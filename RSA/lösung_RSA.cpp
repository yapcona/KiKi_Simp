#include <iostream>
using namespace std;

// berechnet aus dem öffentlichen Schlüssel e den privaten Schlüssel (das multiplikative Inverse von e modulo phi)
unsigned getPrivateKey(unsigned e, unsigned phi)
{
	unsigned a = phi, b = e;
	unsigned d = 0, u = 1;
	while (b != 0)
	{
		unsigned q = a / b;
		unsigned x = b; // Variable zum Zwischenspeichern
		b = a - q * b;
		a = x;
		x = u;
		u = d - q * u;
		d = x;
	}
	if (a > 1) {
		cout << "Fehler: e und phi nicht teilerfremd" << endl;
		exit(1);
	}
	return d;
}

// Diese Funktion berechnet die Potenz a ^ b modulo n
unsigned modularPower(unsigned a, unsigned b, unsigned n)
{
	unsigned res = (b & 1) ? a : 1;
	b >>= 1;
	while (b)
	{
		a = a * a % n;
		if (b & 1) res = res * a % n;
		b >>= 1;
	}
	return res;
}

// Diese Funktion ver- oder entschlüsselt den Klartext 'text' elementweise mit dem Schlüssel 'key'
void RSA(unsigned *text, int len, unsigned n, unsigned key)
{
	for (int i = 0; i < len; i++) // for-Schleife, die die Zeichen des Textes durchläuft
	{
		unsigned c = modularPower(text[i], key, n); // ver- bzw. entschlüsselt text[i]
		text[i] = c;
	}
}

int main()
{
	unsigned p = 223; // die Primzahlen p und q
	unsigned q = 127;
	unsigned n = p * q;
	unsigned e = 121; // Der öffentliche Schlüssel
	unsigned phi = (p - 1) * (q - 1);
	unsigned d = getPrivateKey(e, phi); // Erzeugt den privaten Schlüssel

	const char *klartext = "Werde Mitglied bei Wikipedia!";
	unsigned text[100];
	int len = 0;
	while (klartext[len])
		text[len] = klartext[len], ++len;

	RSA(text, len, n, e); // Verschlüsseln
	// Ausgabe des verschlüsselten Texts auf der Konsole:
	for (int i=0 ; i < len ; ++i)
		cout << ' ' << text[i];
	cout << '\n';

	RSA(text, len, n, d); // Entschlüsseln
	// Ausgabe des Dechiffrats:
	for (int i=0 ; i < len ; ++i)
		cout << (char)text[i];
	cout << '\n';
}