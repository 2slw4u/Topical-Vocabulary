#include <iostream>

using namespace std;

int main()
{
    int n, m, a, b;
    cin >> n >> m;
    int matrix[n][n];
    for (int i = 0; i < n; ++i) {
        for (int j = 0; j < n; ++j) {
            matrix[i][j] = 0;
        }
    }
    for (int i = 0; i < m; ++i){
        cin >> a >> b;
        matrix[a-1][b-1] = 1;
        matrix[b-1][a-1] = 1;
    }
    for (int i = 0; i < n; ++i) {
        for (int j = 0; j < n; ++j) {
            cout << matrix[i][j] << ' ';
        }
        cout << endl;
    }
}
