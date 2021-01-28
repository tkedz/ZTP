#include <iostream>
using namespace std;

int main()
{
	long long n;
	cin >> n;
	if (n == 0)
	{
		cout << n;
		return 0;
	}
	else if (n == 2 || n == 1)
	{
		cout << "NIE" << endl;
		return 0;
	}

	for (long long i = 1; i <= n; i += 2)
	{
		cout << i << " ";

	}
	for (long long i = 0; i <= n; i += 2)
	{
		if (i != n)
		{
			cout << i << " ";
		}
		else cout << i;
	}

	return 0;
}