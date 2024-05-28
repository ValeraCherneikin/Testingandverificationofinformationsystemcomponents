#include <iostream>
#include <cstdlib>
#include <ctime>
#include <cmath>
using namespace std;

int main() {
    srand(time(0));

    int x = 0, y = 0;
    int t = 0;
    int R;

    cout << "Введите значение R:";
    cin >> R;

    while (x * x + y * y < R * R) {
        int direction = rand() % 4;

        switch (direction) {
            case 0:
                x++;
                 break;
            case 1:
                x--;
                break;
            case 2:
                y++;
                break;
            case 3:
                y--;
                break;
        }

        t++;
    }

    cout << "Частица достигла точки на шаге " << t << endl;
  cout << "Отношение между временем движения и значением R: " << t / R << endl;

    return 0;
}
