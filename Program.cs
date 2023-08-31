// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Text;
string csvFilePath = "TestData.csv";

string[] lines = File.ReadAllLines(csvFilePath); //read every line from the string
int[] scores = new int[4] ;

for (int i=0; i< lines.Length; i++)  // extract digits only 
{
    if (Char.IsDigit(char.Parse(lines[i]))){

        for(int j = 0; j < scores.Length; j++){

            scores[j] = int.Parse(lines[i]); // add digits to the scores list
        }



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

GetMaxScoe(scores); // call the method






