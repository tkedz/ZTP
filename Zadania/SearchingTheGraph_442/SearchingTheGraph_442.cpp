#include <iostream>
#include <vector>
#include <deque>
using namespace std;

class Graph
{
	int V;
	vector<int>* adj;
	void DFSUtil(int v, bool visited[]);
public:
	Graph(int V);
	void add_edge(int v, int w);
	void DFS(int v);
	void BFS(int v);
};

Graph::Graph(int V)
{
	this->V = V;
	adj = new vector<int>[V];
}

void Graph::add_edge(int v, int w)
{
	adj[v].push_back(w);
}

void Graph::DFSUtil(int v, bool visited[])
{
	visited[v] = true;
	cout << v + 1 << " ";
	vector<int>::iterator i;
	for (i = adj[v].begin(); i != adj[v].end(); ++i)
	{
		if (!visited[*i])
			DFSUtil(*i, visited);
	}

}

void Graph::DFS(int v)
{
	bool* visited = new bool[V];
	for (int i = 0; i < V; i++)
		visited[i] = false;

	DFSUtil(v, visited);

}

void Graph::BFS(int v)
{
	bool* visited = new bool[V];
	for (int i = 0; i < V; i++)
		visited[i] = false;

	deque<int> queue;
	visited[v] = true;
	queue.push_back(v);

	vector<int>::iterator i;

	while (!queue.empty())
	{
		v = queue.front();
		cout << v + 1 << " ";
		queue.pop_front();

		for (i = adj[v].begin(); i != adj[v].end(); i++)
		{
			if (!visited[*i])
			{
				visited[*i] = true;
				queue.push_back(*i);
			}
		}
	}

}

int main()
{
	int t, n, j, i, m, k, a, v, c = 0, Q;
	cin >> t;
	while (t--)
	{
		cin >> n;
		Graph g(n);
		for (j = 0; j < n; j++)
		{
			cin >> i >> m;
			for (k = 0; k < m; k++)
			{
				cin >> a;
				g.add_edge(i - 1, a - 1);
			}
		}
		cout << "graph " << ++c << endl;
		while (true)
		{
			cin >> v >> Q;
			if (v == 0 && Q == 0)
				break;
			if (Q == 0)
			{
				//cout << "DFS z wierzcholka : " << v << endl;
				g.DFS(v - 1);
			}
			else
			{
				//cout << "BFS z wierzcholka : " << v << endl;
				g.BFS(v - 1);
			}
			cout << endl;
		}
	}
	return 0;
}