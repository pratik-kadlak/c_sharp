using System;

public interface IPrintable {
    void Print();
}

public interface IScannable {
    void Scan();
}

public class MultiFunctionalPrinter: IPrintable, IScannable {
    public void Print(){
        Console.WriteLine("printing document...");
    }

    public void Scan(){
        Console.WriteLine("scanning doucment...");
    }
}

public class Program {
    public static void Main(string[] args){
        MultiFunctionalPrinter mfp = new MultiFunctionalPrinter();
        mfp.Print();
        mfp.Scan();
    }
}