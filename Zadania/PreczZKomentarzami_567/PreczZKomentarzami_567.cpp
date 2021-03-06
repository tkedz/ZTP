﻿#include <iostream>
#include <string>
#include <sstream>
#include <fstream>
using namespace std;

int main()
{
    istreambuf_iterator<char> eos;
    string input(istreambuf_iterator<char>(cin), eos);
    cin >> input;

    string output;
    bool singleLineComment = false;
    bool multilineComment = false;

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