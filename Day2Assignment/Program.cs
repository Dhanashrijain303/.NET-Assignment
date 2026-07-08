// See https://aka.ms/new-console-template for more information

//Q1


/*using System;

class Program
{
    static void Main()
    {
        int totalPackages = 0;
        int qualityCheck = 0;
        int priorityShipment = 0;
        int normalProcessing = 0;

        for (int packageID = 1001; packageID <= 1020; packageID++)
        {
            totalPackages++;

            if (packageID % 4 == 0)
            {
                Console.WriteLine("Package ID: " + packageID + " - Quality Check Required");
                qualityCheck++;
            }
            else if (packageID % 5 == 0)
            {
                Console.WriteLine("Package ID: " + packageID + " - Priority Shipment");
                priorityShipment++;
            }
            else
            {
                Console.WriteLine("Package ID: " + packageID + " - Normal Processing");
                normalProcessing++;
            }
        }

    
        Console.WriteLine("Total packages processed: "+ totalPackages);
        Console.WriteLine("Packages requiring quality check: " + qualityCheck);
        Console.WriteLine("Priority shipments: " + priorityShipment);
        Console.WriteLine("Normal packages: " + normalProcessing);
    }
}
*/

//Q2


using System;

class Program
{
    static void Main()
    {
        int totalPower = 0;
        int maintenance = 0;
        int normal = 0;
        int efficient = 0;

        for (int lightNo = 1; lightNo <= 30; lightNo++)
        {
            int power = 80 + (lightNo * 5);
            totalPower += power;

            if (power > 180)
            {
                Console.WriteLine("Street Light " + lightNo + " : " + power + " W - Maintenance Required");
                maintenance++;
            }
            else if (power >= 140 && power <= 180)
            {
                Console.WriteLine("Street Light " + lightNo + " : " + power + " W - Normal Operation");
                normal++;
            }
            else
            {
                Console.WriteLine("Street Light " + lightNo + " : " + power + " W - Energy Efficient");
                efficient++;
            }
        }

        double averagePower = (double)totalPower / 30;

        
        Console.WriteLine("Total Power Consumed : " + totalPower + " W");
        Console.WriteLine("Average Power Consumption : " + averagePower + " W");
        Console.WriteLine("Maintenance Required : " + maintenance);
        Console.WriteLine("Normal Operation : " + normal);
        Console.WriteLine("Energy Efficient : " + efficient);
    }
}