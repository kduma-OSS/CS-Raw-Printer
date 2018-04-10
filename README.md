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
