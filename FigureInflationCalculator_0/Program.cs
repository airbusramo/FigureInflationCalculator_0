using System;
using System.Runtime.CompilerServices;

Console.WriteLine("This is a program for calculating the difference in price due to changes in the JPY EGP exchange rate for my figures.");
Console.WriteLine();
Console.WriteLine("Type in the price of each figure in JPY. Write \"Done\" when done writing the prices.");
Console.WriteLine();

int totalPriceJPY = 0;
int figureIncrement = 1;
int oldPriceJPYInt = 0;
int newPriceJPYInt = 0;

float oldPriceEGPFloat = 0;
float newPriceEGPFloat = 0;
float oldConversionRate = 0;
float newConversionRate = 0;
float oldTotalPriceEGP = 0;
float newTotalPriceEGP = 0;
float differenceEGP = 0;
float offsetEGPFloat = 0;
float oldTotalPriceEGPOffset = 0;
float newTotalPriceEGPOffset = 0;

bool totalPriceDone = false;

while (totalPriceDone == false)
{
    Console.Write("Figure {0}: ", figureIncrement);
    int figurePriceJPYInt;
    string figurePriceJPYSting = Console.ReadLine();
    if (figurePriceJPYSting == "Done")
    {
        break;
    }
    int.TryParse(figurePriceJPYSting, out figurePriceJPYInt);
    totalPriceJPY += figurePriceJPYInt;
    figureIncrement++;
}

Console.WriteLine();
Console.WriteLine("To calculate the old conversion rate, enter the old and new figure price in JPY and EGP.");
Console.WriteLine();

Console.Write("Old Figure JPY Price: ");
string oldPriceJPYString = Console.ReadLine();
int.TryParse(oldPriceJPYString, out oldPriceJPYInt);
Console.WriteLine();

Console.Write("Old Figure EGP Price: ");
string oldPriceEGPString = Console.ReadLine();
float.TryParse(oldPriceEGPString, out oldPriceEGPFloat);
Console.WriteLine();

Console.Write("New Figure JPY Price: ");
string newPriceJPYString = Console.ReadLine();
int.TryParse(newPriceJPYString, out newPriceJPYInt);
Console.WriteLine();

Console.Write("New Figure EGP Price: ");
string newPriceEGPString = Console.ReadLine();
float.TryParse(newPriceEGPString, out newPriceEGPFloat);
Console.WriteLine();

Console.WriteLine("Now enter in an offset for the total EGP price if needed.");
Console.WriteLine();

string offsetEGPString = Console.ReadLine();
float.TryParse(offsetEGPString, out offsetEGPFloat);

oldConversionRate = oldPriceEGPFloat / oldPriceJPYInt;
newConversionRate = newPriceEGPFloat / newPriceJPYInt;
oldTotalPriceEGP = totalPriceJPY * oldConversionRate;
newTotalPriceEGP = totalPriceJPY * newConversionRate;
differenceEGP = newTotalPriceEGP - oldTotalPriceEGP;
oldTotalPriceEGPOffset = oldTotalPriceEGP + offsetEGPFloat;
newTotalPriceEGPOffset = newTotalPriceEGP + offsetEGPFloat;
Console.WriteLine();

Console.WriteLine("Here are the results.");
Console.WriteLine();

Console.WriteLine("EGP price difference: {0}", differenceEGP);
Console.WriteLine();

Console.WriteLine("Total old EGP price: {0}", oldTotalPriceEGP);
Console.WriteLine("Total new EGP price: {0}", newTotalPriceEGP);
Console.WriteLine();

Console.WriteLine("Total old EGP price with offset: {0}", oldTotalPriceEGPOffset);
Console.WriteLine("Total old EGP price with offset: {0}", newTotalPriceEGPOffset);
Console.WriteLine();

Console.WriteLine("Press any key to close the program.");
Console.ReadKey();