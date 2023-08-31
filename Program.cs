// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Text;
string csvFilePath = "TestData.csv";

string[] lines = File.ReadAllLines(csvFilePath); //read every line from the string
int[] scores = new int[4] ;

string input = "ABC3454 ";
string output = string.Concat( input.Where( Char.IsDigit ) );

Console.WriteLine(output);

for (int i=0; i< lines.Length; i++)  // extract digits only 
{
   
   string number = string.Concat(lines[i].Where(Char.IsDigit));
    for(int j= 0; j< scores.Length; j++){

        scores[j] = int.Parse(number);
    }

}

 void GetMaxScoe(int[] sourceArray)
{
    int maxElement = sourceArray[0];
    for (int index = 1; index < sourceArray.Length; index++)  // parse in the scores array and get the maximum score
    {
        if (sourceArray[index] > maxElement)
            maxElement = sourceArray[index];
    }

    Console.WriteLine(maxElement);
    
}

GetMaxScoe(scores);






