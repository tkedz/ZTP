#include <iostream>
#include <string>
#include <sstream>
using namespace std;

int main()
{
    string input;
    string output;
    bool singleLineComment = false;
    bool multilineComment = false;

    cin >> input;
    int i = 0;
    while (i < input.size()) {
        
        if (singleLineComment == true && input[i] == '\n') {
            singleLineComment = false;
            i++;
        }
        else if (multilineComment && input[i] == '*' && input[i + 1] == '/') {
            multilineComment = false;
            i += 2;
        }
        else if (singleLineComment || multilineComment) {
            i++;
        }
        else if (input[i] == '/' && input[i + 1] == '/') {
            singleLineComment = true;
            i += 2;
        }
        else if (input[i] == '/' && input[i + 1] == '*') {
            multilineComment = true;
            i += 2;
        }
        else {
            output += input[i];
            i++;
        }
    }
    cout << output;
}