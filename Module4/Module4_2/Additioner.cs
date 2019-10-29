namespace Module4_2
{
	class Additioner
	{
		public int AddUpIntNumbers(int firstNumber, int secondNumber)
		{
			return firstNumber + secondNumber;
		}

		public int AddUpIntNumbers(int firstNumber, int secondNumber, int thirdNumber)
		{
			return firstNumber + secondNumber + thirdNumber;
		}

		public double AddUpThreeFractionalNumbers(double firstNumber, double secondNumber, double thirdNumber)
		{
			return firstNumber + secondNumber + thirdNumber;
		}

		public string ConcatenateStrings(string firstString, string secondString)
		{
			return firstString + secondString;
		}

		public int[] AddUpArrays(int[] firstArray, int[] secondArray)
		{
			int[] longArray;
			int[] shortArray;

			if (firstArray.Length > secondArray.Length)
			{
				longArray = firstArray;
				shortArray = secondArray;
			}
			else
			{
				longArray = secondArray;
				shortArray = firstArray;
			}

			int[] newArray = new int[longArray.Length];

			for (int index = 0; index < longArray.Length; index++)
			{
				if (index < shortArray.Length)
				{
					newArray[index] = shortArray[index];
				}
				newArray[index] += longArray[index];
			}

			return newArray;
		}
	}
}
