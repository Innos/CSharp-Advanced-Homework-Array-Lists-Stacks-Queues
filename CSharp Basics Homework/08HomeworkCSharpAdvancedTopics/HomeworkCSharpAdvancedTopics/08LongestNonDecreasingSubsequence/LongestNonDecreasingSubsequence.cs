using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LongestNonDecreasingSubsequence
{
 private static int[] GetLongestNonDecreasingSubsequence(int[] numbers, out int endPosition)
    {    
        int tempLength = 0;   
        //holds the length of the biggest previously found sequence that can be continued by J for the current iteration of J
        //temp variable gets reset in each J iteration
        int maxLengthOFSequence = 0;   
        //the length of the biggest sequence found
        endPosition = 0;
        // Holds the end position of the longest sequence
        int n = numbers.Length;
        int[] Lengths = new int[n];
        //An array that holds the biggest possible sequence length that J forms for each iteration of J (note it assigns Lengths[j] outside of the I cycle,
        //after the I Cycle finds the biggest length of a previous sequence that J can continue(tempLength))(it's index corresponds to the element)
        //maxLengthOFSequence checks after every iteration of J to see if a new LNDS(Longest Non Decreasing Subsequence) is found 
        int[] lastElementPointer = new int[n];
        //the value of this element points to the previous element in the sequence ex. lastElementPointer[element7] = element4 
        //(in this situation element7 is the current element in the sequence and element4 is the previous element)
        Lengths[0] = 1;   
        //Assign max length of a potential sequence the first element can form as 1 (because at this point we have only 1 element to work with)               
        for (int j = 1; j < n; j++)
        { 
            lastElementPointer[j] = j;
            for (int i = 0; i < j; i++)
            {  
                //2 for cycles one cycles the element J and the second checks J against all numbers that came before it
                if (numbers[i] <= numbers[j] && Lengths[i] > tempLength)
                {     
                    tempLength = Lengths[i];  
                    lastElementPointer[j] = i;
                    //If the conditions are met (i<j(indexes) and numbers[i]<= numbers[j]) and element J can continue a sequence, length of said sequence 
                    //is assigned to tempLength and position of previous element is assigned to lastElementPointer with the index of J(current element)
                }
            }
            Lengths[j] = 1 + tempLength;
            //Assigns Length to the current element J based on the max sequence it can form with any element I 
            tempLength = 0;
            if (Lengths[j] > maxLengthOFSequence)
            {
                maxLengthOFSequence = Lengths[j];
                endPosition = j;
            }
        }
        return lastElementPointer;
    }

    static void Main()
    {
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
        int n = numbers.Length;
        int endPosition;
        int[] lastElementPointer = GetLongestNonDecreasingSubsequence(numbers, out endPosition);
        int j;
        List<int> sequenceElements = new List<int>();
        for (j = endPosition; j > 1 && j != lastElementPointer[j]; j = lastElementPointer[j])
        {
            sequenceElements.Add(numbers[j]);
        }
        sequenceElements.Add(numbers[j]);
        if (j != lastElementPointer[j])
        {
            sequenceElements.Add(numbers[lastElementPointer[j]]);
        }
        sequenceElements.Reverse();
        Console.WriteLine(String.Join(" ", sequenceElements.ToArray()));
    }
}







