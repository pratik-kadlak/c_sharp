using System;
 
public class OuterClass {
    private string outerField = "I belong to OuterClass";
 
    public class InnerClass {
        private OuterClass outer;
        
        public InnerClass(OuterClass outer){
            this.outer = outer;
        }
 
        public void DisplayOuterField(){
            Console.WriteLine(outer.outerField);
        }
    }

    public static class StaticNestedClass {
        public static void ShowMessage() {
            Console.WriteLine("Hello from Static Nested Class");
        }
    }


}
 
class Program {
    static void Main() {
        OuterClass outerObject = new OuterClass();
        OuterClass.InnerClass innerObject = new OuterClass.InnerClass(outerObject);
        innerObject.DisplayOuterField();

        //  A static nested class is independent of an instance of the outer class, whereas an inner class depends on it.
        OuterClass.StaticNestedClass.ShowMessage();
    }
}