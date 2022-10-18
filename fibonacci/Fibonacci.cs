int A = 0;
int B = 1;
int C = 1;

while (C <= 233) {
    C = A + B;
    Console.Write("." + C + ".");
    A = B;
    B = C;
}


