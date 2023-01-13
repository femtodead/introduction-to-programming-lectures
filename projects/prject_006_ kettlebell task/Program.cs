int a = 3;
int b= 4;
int c = 5;
int z = 6;
int d = 1;
int max = a;

if (max < a) max = a;
if (max < b) max = b;
if (max < c) max = c;
if (max < z) max = z;
if (max < d) max = d;

Console.WriteLine(max);