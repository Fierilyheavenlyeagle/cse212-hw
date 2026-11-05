using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting
    /// with 'number' followed by multiples of 'number'.
    /// For example, MultiplesOf(7, 5) will result in:
    /// {7, 14, 21, 28, 35}.
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>
    /// Array of doubles that are the multiples of the supplied number.
    /// </returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Create an array with the requested length.
        // Step 2: Use a loop to visit every position in the array.
        // Step 3: Calculate the multiple for each position.
        // Step 4: Store the calculated value in the array.
        // Step 5: Return the completed array.

        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.
    /// For example, if the data is
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9}
    /// and the amount is 3, the result will be:
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.
    /// The amount will be between 1 and data.Count, inclusive.
    ///
    /// This function modifies the existing list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Calculate the starting index of the elements
        // that need to be moved to the beginning.
        // Step 2: Copy those elements into a temporary list.
        // Step 3: Remove the copied elements from the original list.
        // Step 4: Insert the saved elements at the beginning.
        // Step 5: The original list is now rotated to the right.

        int start = data.Count - amount;

        List<int> lastElements = data.GetRange(start, amount);

        data.RemoveRange(start, amount);

        data.InsertRange(0, lastElements);
    }
}