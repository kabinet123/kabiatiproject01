using UnityEngine;

class TestScript : MonoBehaviour
{
    void Start()
    {
        // Szia! Csabi vagyok

        /* Komment */

        /* T�bb
         Soros
        Komment */

        Debug.Log("Hello Unity!");
        Debug.Log($"Hello {name}!");

        // --------------------------

        // V�ltoz�k
        int myFirstVariable;
        myFirstVariable = 76;

        Debug.Log(myFirstVariable);  // 76
        myFirstVariable = 7;
        Debug.Log(myFirstVariable);  // 7

        int myInt = 5; // Integer  = Eg�sz sz�m
        float myFloat = 45.67f; // Floating Point = Tizedes t�rt sz�m
        string myText = "khns�rohn";  // String = Sz�veg
        bool myBool1 = true;  // Logical type = Eld�ntend� t�pus

        bool myBool2 = false;
        myBool2 = true;

        // --- Sz�mok m�veletei -------------------------------

        int i1 = 12;
        int i2 = 5;

        int i3 = i1 + i2;  // 17
        int i4 = i1 - i2;  // 7
        int i5 = i1 * i2;  // 60
        int i6 = i1 / i2;  // 2   (Lev�gja a v�g�t)

        float f0 = i1;    // Automatikus �talak�t�s
        int i7 = (int)f0; // Explicit kasztol�s
        float f1 = i1 / (float)i2;  // Sz�ks�ges

        int i8 = i1 % i2;  // Modulo (Marad�k)    2

        int i9 = 13 % 4;   // 1
        int i10 = 33 % 10; // 3




        // -------------------

        int a, b, c;

        a = 5;
        b = 3;
        c = a + b;
        Debug.Log(c);  // 8

        c = 2;
        Debug.Log(c);  // 2

        // --------------------

        a = a + b;   // 8
        a = a + b;   // 11

        int l�ved�k = 10;
        l�ved�k = l�ved�k - 1;


        // R�vid�t�sek

        a += b;   // a = a + b;
        a -= b;   // a = a - b;
        a *= b;   // a = a * b;
        a /= b;   // a = a / b;
        a %= b;   // a = a % b;

        a = a - 1;
        a--;
        // --a;   M�g ne

        a = a + 1;
        a++;

        // ---------------------

        a = 2;
        b = 3;
        c = 5;

        int i11 = a + b * c; // 17
        int i12 = 2 - ((a + b) * c); // �tz�r�jelezhet�
        Debug.Log(i11);

        float f3 = 2 / 3f;

        //--- String m�veletek -----------------------

        string s1 = "alma";
        string s2 = "ban�n";

        string s3 = s1 + ", " + s2;  // "alma, ban�n"
        string s4 = $"{s1}, {s2}";   // "alma, ban�n"

        string s5 = f3.ToString();    // "0.6666666"

        string s6 = f3 + s1;          // "0.66666alma"

        float f4 = float.Parse(s5);
        // float i13 = int.Parse(s1);     // ERROR

        //--- Bool m�veletek -----------------------

        i1 = 12;

        bool b1 = i1 > i2;
        bool b2 = 3 > 12;    // false
        bool b3 = 3 < 12;    // true
        bool b4 = 3 < 3;     // false
        bool b5 = 3 == 4;    // false     // Egyenl�-e
        bool b6 = i1 == 10;  // false
        bool b7 = i1 != 10;  // true

        bool b8 = 3 >= 3;    // true    // Nagyobb vagy egyenl�
        bool b9 = 3 <= 3;    // true    // Kisebb vagy egyenl�

        s1 = "alma";
        s2 = "ban�n";
        bool b10 = s1 == "alma";  // true
        bool b11 = s1 != "alma";  // false
        bool b12 = s2 == "alma";  // false
        bool b13 = s3 != "alma";  // true
    }
}