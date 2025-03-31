using System;

namespace _1_event
{
    public delegate void EventName(); // Event Creation
    public class class1 
    {
        public event EventName eventObject; // Event Object Creation
        public void RaiseEvent() // just a normal method used to raise event.
        {
            if (eventObject != null) // allow the Event Call only if subscribers count not equal to zero. to avoid exception. 
            {
                eventObject(); // Event Call (or) raising event.
            }
        }       
    }
    public class MainProgram 
    {
        public static void print1() { Console.WriteLine("print1 in main()"); }
        public void print2() { Console.WriteLine("print2 in main()"); }
        public static void Main(string[] args) 
        {
            class1 class1_Obj = new class1();

            class1_Obj.eventObject += print1;   // static-method subscribing(or)linking to event Object

            MainProgram program = new MainProgram();
            class1_Obj.eventObject += program.print2;   // non-static-method subscribing(or)linking to event Object

            class1_Obj.RaiseEvent(); // calling the RaiseEvent method to make a event call
            Console.ReadKey();
        }
    }
}


//using System;

//namespace _1_event
//{
//    // Step 1: Define a delegate that matches the signature of the event handler method.
//    public delegate void ButtonClickEventHandler(object sender, EventArgs e);

//    // Step 2: Define a class that contains the event.
//    public class Button
//    {
//        // Step 3: Declare the event using the delegate.
//        public event ButtonClickEventHandler Click;

//        // Step 4: Create a method to raise the event.
//        protected virtual void OnClick()
//        {
//            // Check if there are any subscribers to the event.
//            if (Click != null)
//            {
//                // Raise the event.
//                Click(this, EventArgs.Empty);
//            }
//        }

//        // Step 5: Simulate a button click.
//        public void SimulateClick()
//        {
//            Console.WriteLine("Button clicked!");
//            OnClick();
//        }
//    }

//    // Step 6: Define a class that will handle the event.
//    public class Program
//    {
//        // Step 7: Define the event handler method.
//        public static void Button_Click(object sender, EventArgs e)
//        {
//            Console.WriteLine("Button click event handled!");
//        }

//        public static void Main(string[] args)
//        {
//            // Step 8: Create an instance of the Button class.
//            Button button = new Button();

//            // Step 9: Subscribe to the event.
//            button.Click += Button_Click;

//            // Step 10: Simulate a button click.
//            button.SimulateClick();

//            Console.ReadLine();
//        }
//    }
//}

