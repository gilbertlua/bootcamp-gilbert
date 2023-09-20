namespace DesignPatternProxy{
    public class Program{
        static void Main(){
            // AccessWithoutProxy();
            AccessWithProxy();
        }
        static void AccessWithoutProxy(){
            Home home = new Home();
            Visitor visitor = new Visitor("haris");
            visitor.VisitorKnockDoor(home);
        }

        static void AccessWithProxy(){
            Home home = new Home();
            Visitor visitor = new Visitor("hasis");
            Proxy proxy = new Proxy(home,visitor.GetName());
            visitor.VisitorKnockDoor(proxy);
        }

    }
}