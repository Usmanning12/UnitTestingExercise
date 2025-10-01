using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
   public class UnitTests
   {
       [Theory]
       [InlineData(10, 2, 6, 18)]
       public void Addition(int num1, int num2, int num3, int expected)
       {
           //Arrange//
           var calculator = new Calculator();
           //Act//
           int sum = calculator.Add(num1, num2, num3);
           
           Assert.Equal(expected, sum);
       }

      

       [Theory]
       [InlineData(10,2,8)]
       public void Subtract(int minuend, int subtrahend, int expected)
        {
            //Arrange// , 
            var calculator = new Calculator();
            
            //Act// 
            var result = calculator.Subtract(minuend,subtrahend); 
            
            Assert.Equal(expected, result);
        }

        
        


        // Keep track of which number is getting passed as minuend and subtrahend


        // Step 5: Navigate to the UnitTests.cs file and complete the SubtractTest unit test method


        // Step 6: 
        // Create a Multiply method that passes 2 integers

        


        // Step 7: Navigate to the UnitTests.cs file and complete the MultiplyTest unit test method 


        // Step 8: 
        // Create a Divide method that passes 2 integers
        

        // Step 9: Navigate to the UnitTests.cs file and complete the DivideTest unit test method 


        //*****NOW RUN ALL OF YOUR TESTS*********//
    }

   
}