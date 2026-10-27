// LinkedIn Learning Course exercise file for Advanced C# Programmin by Joe Marini
// Example file for chained events

namespace ChainedEvents
{
    // define the delegate for the event handler
    public delegate void MyEventHandler(string value);

    class EventPublisher
    {
        private string TheVal;
        // declare the event handler
        public event MyEventHandler ValueChanged;
        // TODO4: Use the EventArgs class
        public event EventHandler<ObjChangedEventArgs> ObjChanged;

        public string Val
        {
            set {
                this.TheVal = value;
                // when the value changes, fire the event
                this.ValueChanged(TheVal);
                // TODO5: Use the custom event handler
                this.ObjChanged(this, new ObjChangedEventArgs() {PropChanged = value});
            }
        }
    }

    // TODO3: Create a subclass of EventArgs for our use
    class ObjChangedEventArgs : EventArgs
    {
        public string PropChanged;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // create the test class
            EventPublisher obj = new EventPublisher();

            // TODO1: Connect multiple event handlers
            obj.ValueChanged += new MyEventHandler(changeListener1);
            obj.ValueChanged += new MyEventHandler(changeListener2);

            // TODO2: Use an anonymous delegate as the event handler
            obj.ValueChanged += delegate(string s)
            {
                Console.WriteLine($"This value {s} came from anonymous delegate function");
            };

            // TODO6: Listen for the custom event we defined with EventArgs
            obj.ObjChanged += delegate(object sender, ObjChangedEventArgs e)
            {
                Console.WriteLine($"{sender.GetType()} had the {e.PropChanged} changed");
            };

            string str;
            do {
                Console.WriteLine("Enter a value: ");
                str = Console.ReadLine();
                if (!str.Equals("exit")) {
                    obj.Val = str;
                }
            } while (!str.Equals("exit"));
            Console.WriteLine("Goodbye!");
        }

        static void changeListener1(string value)
        {
            Console.WriteLine("The value changed to {0}", value);
        }
        static void changeListener2(string value)
        {
            Console.WriteLine("I also listen to the event, and got {0}", value);
        }
    }
}