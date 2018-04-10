/*
 *  LPrinter - A simple line printer class in C#
 *  ============================================
 *  
 *  Written by Antonino Porcino, iz8bly@yahoo.it
 *
 *  26-sep-2008, public domain.
 *
 * 
 *  some useful print codes:
 *  ========================
 *    12 = FF (form feed)
 *    14 = enlarged on
 *    20 = enlarged off
 *    15 = compress on
 *    18 = compress off
 *    ESC + "E" = bold on
 *    ESC + "F" = bold off
 *    
 * 
 */

using System;
using System.Runtime.InteropServices;

namespace RawPrinter
{
    public partial class Printer
    {
        private IntPtr _handlePrinter;
        public string PrinterName;

        public Printer()
        {
            _handlePrinter = IntPtr.Zero;
        }

        public Printer(string printerName) : this()
        {
            PrinterName = printerName;
        }

        public bool Open(string documentName)
        {
            // see if printer is already open
            if (_handlePrinter != IntPtr.Zero)
                return false;

            // opens the printer
            var risp = OpenPrinter(PrinterName, out _handlePrinter, IntPtr.Zero);
            if (risp == false)
                return false;

            // starts a print job
            var printJob = new DOCINFOA
            {
                pDocName = documentName,
                pOutputFile = null,
                pDataType = "RAW"
            };

            if (!StartDocPrinter(_handlePrinter, 1, printJob))
                return false;

            StartPagePrinter(_handlePrinter); //starts a page       
            return true;
        }

        public bool Close()
        {
            if (_handlePrinter == IntPtr.Zero)
                return false;

            if (!EndPagePrinter(_handlePrinter))
                return false;

            if (!EndDocPrinter(_handlePrinter))
                return false;

            if (!ClosePrinter(_handlePrinter))
                return false;

            _handlePrinter = IntPtr.Zero;
            return true;
        }

        public bool SendData(string data)
        {
            if (_handlePrinter == IntPtr.Zero)
                return false;

            var buf = Marshal.StringToCoTaskMemAnsi(data);
            var ok = WritePrinter(_handlePrinter, buf, data.Length, out var done);
            Marshal.FreeCoTaskMem(buf);

            return ok;
        }

        public bool SendData(char data) => SendData(data.ToString());
        public bool SendData(int data) => SendData(((char) data).ToString());
    }
}
