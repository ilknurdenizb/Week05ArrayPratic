
//Q1 creating an array of 10 integers and initializing them to 0
int[] inputnumbers = new int[10];

//Q2 asking the user to enter 10 numbers and storing them in the array
for (int i =0; i< inputnumbers.Length; i++) // Loop through each index of the array
{
    Console.WriteLine("Enter a number: "); // Prompt the user to enter a number
    string inputstring = Console.ReadLine(); // Read the input from the user
    inputnumbers [i] = int.Parse(inputstring); // Convert the input string to an integer and store it in the array at the current index
}
foreach (int number in inputnumbers) //Q3 displaying the numbers in the array
{
    Console.Write($"{number} " );
}
//Q4 adding a new number to the array
Console.WriteLine("\nPlease enter 11th number: "); // Prompt the user to enter an additional number
string addedNumberString = Console.ReadLine(); // Read the input from the user
int addedNumber = int.Parse(addedNumberString); // Convert the input string to an integer

List<int> newNumberList =new List <int>(inputnumbers); // Create a new list initialized with the existing numbers
newNumberList.Add(addedNumber); // Add the new number to the list
int [] newNumbers = newNumberList.ToArray(); // Convert the list back to an array
foreach (int number in newNumbers) // Display the updated array with the new number
{
    Console.Write($"{number} ");
}

//Q4 sorting numbers in descending order
for (int i = 0; i < newNumbers.Length - 1; i++) // Loop through each element except the last one
{
    for (int j = i + 1; j < newNumbers.Length; j++) // Compare with the elements that come after it
    {
        if (newNumbers[i] < newNumbers[j]) // If the current element is less than the next one, swap them
        {
            // Swap
            int temp = newNumbers[i]; // Store the current element in a temporary variable
            newNumbers[i] = newNumbers[j]; // Assign the next element to the current position
            newNumbers[j] = temp; // Assign the temporary variable to the next position
          
        }
    }
}
Console.WriteLine("\nSorted in descending order:");
foreach (int number in newNumbers) // Display the sorted numbers
{
    Console.Write($"{number} "); // Print each number in the sorted array
}

