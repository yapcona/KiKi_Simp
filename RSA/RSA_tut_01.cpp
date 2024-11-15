#include <iostream>

using namespace std;

unsinged getPrivateKey(unsinged e, unsinged phi)
{
    unsigned a = phi, b = e;
    unsigned d = 0, u = 1;
    while (b != 0)´
    {
        unsigned q = a / e;
        unsigned x = b;
        b = a - q * b; // variabel zum zwischenspeicheern
        a =x;
        x = u;
        u = d - q * u;
        d = x;
    }

    if (a > 1)
    {
        cout << "Fehler: e und phi nicht teilerfremd" << endl;
        exit(1);
    }
    return d;
}


unsinged modularPower(unsingeda, unsinged b, unsinged n)
{
    unsigned res 0 ( b& 1) a : 1;
    b >>= 1;
    while (b)
    {
        a = a * a % n;
        if ( b & 1 ) res = res * a % n;
        b >>= 1;
    }
    return res;
}

void RSA(unsigned *text, int len, unsigned n, unsigned key)
{
    for (int i = 0; i < len; i++)
    {
        unsigned c = modularPowe(text[ir, key, n
;
    }
}