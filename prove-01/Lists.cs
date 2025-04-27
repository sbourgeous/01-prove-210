namespace prove_01;

public class Lists
{
    /// <summary>
    /// This function will produce a list of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Create an array to store the multiples
        double[] multiples = new double[length];

        // Populate the array with multiples of the given number
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1); // Calculate the multiple
        }

        return multiples; // Return the array
    }
    
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// <c>&lt;List&gt;{1, 2, 3, 4, 5, 6, 7, 8, 9}</c> and an amount is 3 then the list returned should be 
    /// <c>&lt;List&gt;{7, 8, 9, 1, 2, 3, 4, 5, 6}</c>.  The value of amount will be in the range of <c>1</c> and 
    /// <c>data.Count</c>.
    /// <br /><br />
    /// Because a list is dynamic, this function will modify the existing <c>data</c> list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Ensure the amount is within the valid range
        amount = amount % data.Count;

        // Divide the list into two parts and rearrange
        List<int> tail = data.GetRange(data.Count - amount, amount); // Last 'amount' elements
        List<int> head = data.GetRange(0, data.Count - amount); // Remaining elements

        // Clear the original list and add the rotated elements
        data.Clear();
        data.AddRange(tail); // Add the tail part first
        data.AddRange(head); // Add the head part next
    }
}