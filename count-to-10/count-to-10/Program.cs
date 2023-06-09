// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
double Set, count, total;
int keephistory =0;
double[] History = {0,0,0,0,0};  
Set = Convert.ToDouble( Console.ReadLine()); // this need to go into a loop
/// this is to keep track of 5 pass number
history();


void history()
{
	History[keephistory] = Set;
} 