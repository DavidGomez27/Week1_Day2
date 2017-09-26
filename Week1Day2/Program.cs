using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //What data types have we talked about so far
            //An int is a whole number (no decimals)
            //A string is a collection of characters

            char firstInitial = 'D';
            //Characters or chars are single letters or numbers
            //or symbols

            bool isTired = true;
            //bool means true or false

            //other number data types
            float number = 2.164403304907294849383961032f;
            decimal partialNum = 2.164403304907294849383961032m;
            double someNumber = 2.164403304907294849383961032d;

            Console.WriteLine(number);
            Console.WriteLine(partialNum);
            Console.WriteLine(someNumber);

            //Now lets talk about operators
            // + adds two operands
            // - subtracts second operand from the first
            // * multiplies properties
            // / as operator, divides first operand by second
            // % Modulus - divides and checks remainder
            // ++ Increments operator by one and is used for ints
            // -- Decrements decreases value by one 
            
            //Arithmitic Operators below
            // == Checks if the values of two operators are equal
            // and if they are, returns bool true
            // != bang  checks values of two operands are equal
            //and if they are NOT equal, returns bool true

            int JarrydAge = 29;
                int DanielAge = 32;
            Console.WriteLine(JarrydAge != DanielAge);

            /*
             *  > checks value of the left operand is greater than the value
             *  of the right operand, and if yes,then condition is true
             *  < opposite of above, condition still true if yes
             *  >=Checks if value of left operand is greater than or equal to the
             *  value of the right operand and if yes, condition becomes true
             *  <=opposite of above, condition still true if yes
             *  %% we call AND operator. if both the operands are true non zero, then condition becomes true
             *  
             *  || we call OR operator. If any of the two operands is non zero then condition becomes true
             *  
             *   
             
             
             
            

        
        


        }
    }
}
