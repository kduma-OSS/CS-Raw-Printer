using RawPrinter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawPrinterExample
{
    public partial class RawPrinterExampleForm : Form
    {
        private readonly Printer _printer;

        public RawPrinterExampleForm()
        {
            InitializeComponent();

            _printer = new Printer(
                new PrinterSettings().PrinterName
            );
        }

        private void RawPrinterExampleForm_Load(object sender, EventArgs e)
        {
            LSelectedPrinter.Text = _printer.PrinterName;
        }

        private void BChoicePrinter_Click(object sender, EventArgs e)
        {
            PrintDialog.PrinterSettings = new PrinterSettings()
            {
                PrinterName = _printer.PrinterName
            };

            if (PrintDialog.ShowDialog() != DialogResult.OK)
                return;

            _printer.PrinterName = PrintDialog.PrinterSettings.PrinterName;
            LSelectedPrinter.Text = _printer.PrinterName;
        }

        private void BPrintSample_Click(object sender, EventArgs e)
        {
            if (!_printer.Open("Example Print Name")) return;
            _printer.SendData("This text is sent to a line printer\r\n");
            _printer.SendData("===================================\r\n");
            _printer.Close();
        }

        private void BSayHello_Click(object sender, EventArgs e)
        {
            if (!_printer.Open("Say Hello Example")) return;
            _printer.SendData($"Hello {TBName.Text}!\r\n");
            _printer.Close();
        }
    }
}
