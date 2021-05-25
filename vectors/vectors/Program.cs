using System;

namespace vectors
{
    class Program
    {
		static void Main(string[] args)
		{

		    string surfaceVec;
			int[,] lightArr = new int[2, 2];
			double reflected;

			Console.WriteLine("Please enter your surface vector(x,y) here: ");
			surfaceVec = Console.ReadLine();
			Console.WriteLine("\n");
			string surfaceVec2 = Console.ReadLine();
			Console.WriteLine("\n");

			//Light Scalar
			//	lightArr[0, 0] = Int32.Parse(args[1]);



			//	lightArr[0, 1] = Int32.Parse(args[2]);
			//Surface Scalar
			lightArr[0, 0] = 5;
			lightArr[0, 1] = 1;
			lightArr[1, 0] = Int32.Parse(surfaceVec);
			lightArr[1, 1] = Int32.Parse(surfaceVec2);


			//Call Reflect() to produce the relected light array against the surface array. -- Line 25 

			for (int i = 0; i < lightArr.GetUpperBound(0)+1; i++)
				Console.WriteLine("Vect {2}:[{0}, {1}]", lightArr[i, 0], lightArr[i, 1], i);

			// 2D Reflection
			reflected = Reflect(lightArr);

			// 3d Reflection

			//cont.

		}


		double Reflect(int[2,2] lightRay)
        {
			double ret;

			//body
			//gives thew angle at which a 0,0 plane is reflected.
			//needs arctan(0/1) = ret

			//future implementation will need to have a desired angle and distort the 0,0 plane to reach the angle needed. Highschool math easy.
			return ret;
        }
    }
}