# CS-Raw-Printer

Raw Printing helper for dot matrix and thermal printers.

## Usage
```cs
var printer = new RawPrinter.Printer("Printer Name");
if (!printer.Open("Job Name")) return;
printer.SendData("This text is sent to a line printer\r\n");
printer.SendData("===================================\r\n");
printer.Close();
```

## Antonino Porcino
A special thanks to [Antonino Porcino](https://www.codeproject.com/Articles/29709/Line-Printer-Class-in-C), an original code creator that this package is based on.
