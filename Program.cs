// Challenge 1
bool amProgrammer = true;           // true va sin comillas dobles("") para asignarse a una varible tipo bool
int Age = 27;                       // Age es del tipo int pero, se le está asignando un valor doble (27.9)
List<string> Names = new List<string>();
Names.Add("Monica");                // se debe usar el metodo Add() para agregar un valor a una lista
Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Hello", "0");
MyDictionary.Add("Hi there", "0");  // se está agregando un valor int cuando debería ser String
// This is a tricky one! Hint: look up what a char is in C#
string MyName = "MyName";           // solo las variables tipo char usan Comillas simples(''), las variables tipo string deben usar comillas dobles("")

// Challenge 2
List<int> Numbers = new List<int>() {2,3,6,7,1,5};
for(int i = Numbers.Count - 1; i >= 0; i--) // el ciclo for inicia en un indice fuera del rango de la lista
{
    Console.WriteLine(Numbers[i]);
}
// Challenge 3
List<int> MoreNumbers = new List<int>() {12,7,10,-3,9};
foreach(int i in MoreNumbers)           // al usar foreach no se utiliza indice si no una variable auxiliar que almacene el valorde manera temporar
{
    Console.WriteLine(i);               // asi que en este caso no isamos i como indice si no como variable
}
// Challenge 4
List<int> EvenMoreNumbers = new List<int> { 3, 6, 9, 12, 14 };
foreach (int num in EvenMoreNumbers)
{
  if (num % 3 == 0)
  {
    // num = 0;                          // no podemos asignarle un valor a num ya que esta es la variable auciliar de la iteración
  }
}

// si lo que queremos es reemplazar con un 0 los valores en la lista que sean multiplo de 3 lo mejor es usar un ciclo for
for (int j = 0; j < EvenMoreNumbers.Count; j++)
{
  if (EvenMoreNumbers[j] % 3 == 0)
  {
    EvenMoreNumbers[j] = 0;
  }
  Console.WriteLine(EvenMoreNumbers[j]);
}
// Challenge 5
// What can we learn from this error message?
/* se puede acceder a un cararcter especifico de un string utilizando un indice, pero no se puede actualizar ese caracter utilizando el indice,
esta propiedad de los string es solo de lectura y no de escritura, para modificar el error debemos asignar el string completo corregido */
string MyString = "superduberawesome";
Console.WriteLine(MyString[7]);
MyString = "superduperawesome";
Console.WriteLine(MyString.Substring(7, 1));
// Challenge 6
// Hint: some bugs don't come with error messages
// el problema aquí es que solo se mostrará el mensaje si la funcion Next() nos entrega un 12, el resto de la veces no mostrará nada
Random rand = new Random();
int randomNum = rand.Next(12);
if(randomNum == 12)
{
  Console.WriteLine("Hello");
}