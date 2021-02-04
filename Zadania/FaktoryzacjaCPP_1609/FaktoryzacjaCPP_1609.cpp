#include <iostream>
using namespace std;

int dzielniki[8000001];
int main()
{

    //sito erastotenesa
    dzielniki[0] = 1;
    for (int i = 1; i < 8000001; i++)
        dzielniki[i] = i;

    for (int i = 2; i * i <= 8000000; i++) {
        if (dzielniki[i] == i) {
            for (int j = i * i; j <= 8000000; j += i) {
                if (dzielniki[j] == j)
                    dzielniki[j] = i;
            }
        }
    }

    int t;
    cin >> t;
    for (int i = 0; i < t; i++) {
        int num;
        cin >> num;
        cout << dzielniki[num];
        num /= dzielniki[num];
        while (num > 1) {
            cout << "*" << dzielniki[num];
            num /= dzielniki[num];
        }
        cout << endl;
    }

    return 0;
}

