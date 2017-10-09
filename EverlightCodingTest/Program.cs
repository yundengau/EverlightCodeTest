using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EverlightCodingTest.Model;
using EverlightCodingTest.Services;

namespace EverlightCodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BTreeNode rootNode = new BTreeNode();
            FullBinaryTreeService service = new FullBinaryTreeService();

            //Allow the user to input depth by console
            Console.WriteLine("Please enter the depth of the Tree: ");
            string depthString = Console.ReadLine();
            while (!depthString.All(char.IsDigit))
            {
                Console.WriteLine("The format of the input is wrong. Please enter the depth of the Tree: ");
                depthString = Console.ReadLine();
            }

            //Allow the user to input depth by console
            Console.WriteLine("Please enter the ball number: ");
            string ballNumberString = Console.ReadLine();
            while (!ballNumberString.All(char.IsDigit))
            {
                Console.WriteLine("The format of the input is wrong. Please enter the ball number: ");
                ballNumberString = Console.ReadLine();
            }

            int depth = int.Parse(depthString);
            int ballNumber = int.Parse(ballNumberString);

            //Initialize the binary tree basing on its depth
            BTreeNode[][] bTree=service.BuildFullBinaryTree(ref rootNode, depth);

            //Get the predicted result
            PredictionService predictionService = new PredictionService();
            char[] predictResult = predictionService.Predict(bTree, depth, ballNumber);

            //Get the simulated result
             TraversalService traversalService = new TraversalService();
            char[] simulateResult = traversalService.FindNotHitContainer(rootNode, depth, ballNumber);

            //Start the comparison
            if (predictResult.Length != simulateResult.Length)
            {
                Console.WriteLine("The return result element number are different. The simulated result is not matching the predicted outcome result.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("The predicted result is:");
            Console.Write(String.Join(" ", predictResult) +"\n");

            Console.WriteLine("The simulated result is:");
            Console.Write(String.Join(" ", simulateResult)+ "\n");

            for (int i = 0; i < predictResult.Length; i++)
            {
                if (predictResult[i] != simulateResult[i])
                {
                    Console.WriteLine("The simulated result is not matching the predicted outcome result.");
                    Console.ReadLine();
                    return;
                }
            }

            Console.WriteLine("The predicted result is the same with the simulatd result.");
            Console.ReadLine();
        }
    }
}
