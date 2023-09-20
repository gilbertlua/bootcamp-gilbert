namespace DesignPatternProxy{
    public class Visitor{
        private string? _visitorName;
        public Visitor(string visitorName){
            _visitorName = visitorName;
        }
        public void VisitorKnockDoor(IHome home){
            home.DoorOpen();
        }
        public string GetName(){
            return _visitorName!;
        }
    }
}