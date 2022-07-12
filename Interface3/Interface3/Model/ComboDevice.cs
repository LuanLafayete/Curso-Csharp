namespace Interface3.Model
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Combo Device procesisng " + document);
        }

        public string Scan()
        {
            return "Combo Device scan result ";
        }

        public void Print(string document)
        {
            Console.WriteLine("Combo Device Printer: " + document);
        }
    }
}
