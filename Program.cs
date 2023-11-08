
using System;
using System.IO;
using System.Text;
string csvFilePath = "TestData.csv";

string[] lines = File.ReadAllLines(csvFilePath); //read every line from the string
int[] scores = new int[4];

List<string> result = new List<string>();

for (int i=1; i< lines.Length; i++)  // extract digits only 
{
   
   string number = string.Concat(lines[i].ToString().Where(Char.IsDigit));
   //Console.WriteLine(number);
    for(int j= 0; j< scores.Length; j++){

        scores[j] = int.Parse(number);

    }

}

 int GetMaxScoe(int[] sourceArray)
{
    int maxElement = sourceArray[0];
    for (int index = 1; index < sourceArray.Length; index++)  // parse in the scores array and get the maximum score
    {
        if (sourceArray[index] > maxElement){
            maxElement = sourceArray[index];
        }
            
    }

    return maxElement;
    
}

//GetMaxScoe(scores);

void Result(){

    for(int i = 1; i < lines.Length; i++){

        string number = string.Concat(lines[i].ToString().Where(Char.IsDigit));

        if( int.Parse(number) == GetMaxScoe(scores)){

            result.Add(lines[i]);

        }
    }

    foreach (var score in result)
    {
        Console.WriteLine(score);
    }

}

Result();






