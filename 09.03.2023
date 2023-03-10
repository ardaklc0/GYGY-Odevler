using System.Diagnostics.Metrics;
using System.Globalization;

// Random array that contains real numbers
double[] numberList = { 1.23, 1.23, 1.64, 1.23, 1.9, 1.12};

// Assigning initial values
double biggestNumber = numberList[0];
double smallestNumber = numberList[0];
double sumOfTheList = 0;
double productOfTheList = 1;
int index = 0;

while (index < numberList.Length) 
{
    // Finding biggest number
    if (biggestNumber < numberList[index])
    {
        biggestNumber = numberList[index];
    }

    // Finding smallest Number
    if (smallestNumber > numberList[index])
    {
        smallestNumber = numberList[index];
    }

    // Sum of the list
    sumOfTheList += numberList[index];

    // Product of the list
    productOfTheList *= numberList[index];

    index++;
}

// Mean of the list
double meanOfTheList = sumOfTheList/(numberList.Length);


// Standart Deviation of The List
double varianceOfTheListNominator = 0;
for (int i = 0; i < numberList.Length; i++)
{
    varianceOfTheListNominator += Math.Pow(numberList[i] - meanOfTheList, 2);
}

// Variance of the list σ^2
double varianceOfTheList = varianceOfTheListNominator/(numberList.Length-1);
// Standart deviation: σ
double standartDeviationOfTheList = Math.Sqrt(varianceOfTheList);



Console.WriteLine($"Biggest number in the list: {biggestNumber}");
Console.WriteLine($"Smallest number in the list: {smallestNumber}");
Console.WriteLine($"Sum of the list: {sumOfTheList}");
Console.WriteLine($"Product of the list: {productOfTheList}");
Console.WriteLine($"Mean of the list: {meanOfTheList}");
Console.WriteLine($"Variance of the list: {varianceOfTheList}");
Console.WriteLine($"Standart deviation of the list: {standartDeviationOfTheList}");
