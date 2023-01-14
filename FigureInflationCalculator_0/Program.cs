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
float offsetEGPFloat = 0;
float moneyAccountFloat = 0;
float differenceEGP = 0;
float moneyRemaining = 0;
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
Console.WriteLine("To calculate the conversion rates, enter the old and new figure prices in JPY and EGP.");
Console.WriteLine();

Console.Write("Old Figure JPY Price: ");
string oldPriceJPYString = Console.ReadLine();
int.TryParse(oldPriceJPYString, out oldPriceJPYInt);

Console.Write("Old Figure EGP Price: ");
string oldPriceEGPString = Console.ReadLine();
float.TryParse(oldPriceEGPString, out oldPriceEGPFloat);

Console.Write("New Figure JPY Price: ");
string newPriceJPYString = Console.ReadLine();
int.TryParse(newPriceJPYString, out newPriceJPYInt);

Console.Write("New Figure EGP Price: ");
string newPriceEGPString = Console.ReadLine();
float.TryParse(newPriceEGPString, out newPriceEGPFloat);
Console.WriteLine();

Console.WriteLine("Now enter in an offset for the total EGP price.");
string offsetEGPString = Console.ReadLine();
float.TryParse(offsetEGPString, out offsetEGPFloat);
Console.WriteLine();

Console.WriteLine("Finally, enter how much money you have to calculate if you have enough.");
string moneyAccountString = Console.ReadLine();
float.TryParse(moneyAccountString, out moneyAccountFloat);
Console.WriteLine();
Console.WriteLine();

oldConversionRate = oldPriceEGPFloat / oldPriceJPYInt;
newConversionRate = newPriceEGPFloat / newPriceJPYInt;
oldTotalPriceEGP = totalPriceJPY * oldConversionRate;
newTotalPriceEGP = totalPriceJPY * newConversionRate;
differenceEGP = newTotalPriceEGP - oldTotalPriceEGP;
oldTotalPriceEGPOffset = oldTotalPriceEGP + offsetEGPFloat;
newTotalPriceEGPOffset = newTotalPriceEGP + offsetEGPFloat;
moneyRemaining = moneyAccountFloat - newTotalPriceEGPOffset;

Console.WriteLine("Here are the results.");
Console.WriteLine();

Console.WriteLine("EGP price difference: {0}", differenceEGP);
Console.WriteLine();

Console.WriteLine("Total old EGP price: {0}", oldTotalPriceEGP);
Console.WriteLine("Total new EGP price: {0}", newTotalPriceEGP);
Console.WriteLine();

Console.WriteLine("Total old EGP price with offset: {0}", oldTotalPriceEGPOffset);
Console.WriteLine("Total new EGP price with offset: {0}", newTotalPriceEGPOffset);
Console.WriteLine();

if (moneyRemaining >= 0)
{
    Console.WriteLine("You have enough money.");
    Console.WriteLine();
}
else
{
    Console.WriteLine("You don't have enough money. You need to add {0}.", Math.Abs(moneyRemaining));
    Console.WriteLine();
}

Console.WriteLine("Press any key to close the program.");
Console.ReadKey();