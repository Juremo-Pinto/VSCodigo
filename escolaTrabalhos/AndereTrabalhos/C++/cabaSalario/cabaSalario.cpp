#include <iostream>
using namespace std;
#include <iomanip>
int main()
{
    cout << endl << "Numero do funcionario: ";
    int numCaba;
    cin >> numCaba;
    cout << "Salario por hora: ";
    float salCaba;
    cin >> salCaba;
    cout << "Horas trabalhadas: ";
    int hrsCaba;
    cin >> hrsCaba;
    cout << endl << "NUMERO: " << numCaba << endl;
    cout << "SALARIO: " << salCaba * hrsCaba << endl;
}