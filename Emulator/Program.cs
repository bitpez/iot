
using System.IO.Ports;

SerialPort serialPort = new()
{
    BaudRate = 9600,
    PortName = "COM3",
};

serialPort.Open();
serialPort.WriteLine("");

while (true) 
{
    string outPut = serialPort.ReadLine();
    
    if (outPut == "All is done.\r")
    {
        serialPort.WriteLine("");
    }
    else
    {
        Console.WriteLine(outPut);
    }
}