#include <iostream>
#include <cstdlib>
using namespace std;
int i;
class Array {
    float* m;
    int n;
public:
    Array(int k) {
        cout << "Constructor with parametr" << endl;
        n = k;
        m = new float[n];
        set_data();
    }
    ~Array() {
        delete m;
        cout << "\nDestructor." << endl;
    }
    void set_data() {
        for (i = 0; i < n; i++) {
            if (i % 2 == 0) {
                m[i] = i + 4.1;
            }
            else {
                m[i] = i - 1.0;
            }
        }
        output();
    }
    void output() {
        cout << "Kolichestvo elementov: " << endl;
        for (i = 0; i < n; i++) {
            cout << m[i] << " ";
        }
    }

    friend void sum(Array obj);
};
void sum(Array obj) {
    float sum = 0.0;
    cout << "\nDodatni element: " << obj.m << "\n";
    for (i = 0; i < obj.n; i++) {
        if (!(i % 2) == 0) {
            cout << obj.m[i] << " ";
            sum = sum + obj.m[i];
        }
    } cout << endl;
    cout << "Summa dodatnih elementiv: " << sum;
}
int main() 
{
    Array arr(15);
    sum(arr);
    system("pause");
    return 0;
}