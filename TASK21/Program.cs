// Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между 
//ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

// 1. Ввести координаты точек xa; ya; xb; yb;
// 2. Разработать метод по нахождению расстояния между ними
// Расстояние = $ \ sqrt {(x2-x1) ^{2} + (y2-y1) ^{2} + (z2-z1) ^{2}} $ 

int x1 = 3;
int y1 = 6;
int z1 = 8;
int x2 = 2;
int y2 = 1;
int z2 = -7;

void Distanse()
{
  int pointX = x2 - x1;
  int pointY = y2 - y1;
  int pointZ = z2 - z1;

  double length = Math.Sqrt(pointX*pointX+pointY*pointY+pointZ*pointZ);
  Console.WriteLine(length);
}
Distanse();