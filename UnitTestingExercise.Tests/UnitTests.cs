using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(10, 2, 6, 18)]
        [InlineData(5, 5, 5, 15)]
        [InlineData(4, 8, 12, 24)]
        [InlineData(24, 24, 24, 72)]
    

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
       [InlineData(40,20,20)]
       [InlineData(15,5,10)]
       [InlineData(30,21,9)]
       
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
        
        [Theory]
        [InlineData(10,2,20)]
        [InlineData(20,20,400)]
        [InlineData(12,12,144)]
        [InlineData(6,6,36)]
        public void Multiply(int num1, int num2,int expected)
        {
            var calculator = new Calculator();
            var result = calculator.Multiply(num1, num2);
            Assert.Equal(expected,result);
        }

        


        // Step 7: Navigate to the UnitTests.cs file and complete the MultiplyTest unit test method 


        // Step 8: 
        // Create a Divide method that passes 2 integers
        [Theory]
        [InlineData(10,2,5)]
        [InlineData(9,3,3)]
        [InlineData(20,5,4)]
        [InlineData(36,6,6)]
        public void Divide(int num1, int num2, int expected)
        {
            var calculator = new Calculator();
            var result = calculator.Divide(num1, num2);
            Assert.Equal(expected,result);
        }
        

        // Step 9: Navigate to the UnitTests.cs file and complete the DivideTest unit test method 


        //*****NOW RUN ALL OF YOUR TESTS*********//
    }

   
}