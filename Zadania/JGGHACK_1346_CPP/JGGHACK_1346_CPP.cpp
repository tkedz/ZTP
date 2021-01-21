#include <iostream>
#include <string>
using namespace std;

int main()
{
    string input;

    while (cin>>input)
    {
        string passwd = "";

        for (int j = 0; j < input.length(); j += 2)
        {
            int tmp = ((int)input[j] - 65) + ((int)input[j + 1] - 65) * 16;
            passwd += (char)tmp;
        }

        cout << passwd <<endl;
    }
}