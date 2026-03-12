#include <iostream>
using namespace std;
#include <iomanip>
#include <windows.h>
#include <locale>
int main()
{
    SetConsoleOutputCP(65001); // permite que o terminal mostre caracteres utf-8 corretamente
    setlocale(LC_ALL, "pt_BR.utf8"); // permite usar acentuação e interpretar caracteres utf-8
    cout << endl << "Código da peça 1: ";
    int peca1;
    cin >> peca1;
    cout << endl << "Numeros de peças 1: ";
    int numPeca1;
    cin >> numPeca1;
    cout << endl << "Preço da peça 1: ";
    float prcPeca1;
    cin >> prcPeca1;
    cout << endl << "Código da peça 2: ";
    int peca2;
    cin >> peca2;
    cout << endl << "Numeros de peças 2: ";
    int numPeca2;
    cin >> numPeca2;
    cout << endl << "Preço da peça 2: ";
    float prcPeca2;
    cin >> prcPeca2;
    cout << endl << "VALOR A PAGAR: " << (numPeca1 * prcPeca1) + (numPeca2 * prcPeca2) << endl;


}