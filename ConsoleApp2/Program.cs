// See https://aka.ms/new-console-template for more information
List<int> lst = new List<int>() { 5, 7, 9, 2 };
lst.Sort();
foreach (int n in lst) 
{
    Console.WriteLine(n);
}