using System;

namespace vectors
{
    class Program
    {
		static void Main(string[] args)
		{

		    string surfaceVec;
			int[,] lightArr = new int[2, 2];
			int i;

			Console.WriteLine("Please enter your surface vector(x,y) here: ");
			surfaceVec = Console.ReadLine();
			Console.WriteLine("\n");

			//Light Scalar
		//	lightArr[0, 0] = Int32.Parse(args[1]);



		//	lightArr[0, 1] = Int32.Parse(args[2]);
			//Surface Scalar
			lightArr[1, 0] = Int32.Parse(surfaceVec);
			lightArr[1, 1] = Int32.Parse(surfaceVec);

			//Call Reflect() to produce the relected light array against the surface array. -- Line 25 

			for (i = 0; i < lightArr.Length; i++)
				Console.WriteLine("Vect {2}:[{0}, {1}]", lightArr[i, 0], lightArr[i, 1], i);
		}
    }
}