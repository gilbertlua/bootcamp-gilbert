namespace DesignPatternProxy{
    public class Proxy:IHome{
        private Home _home;
        private string _name;
        public Proxy(Home home, string name){
            _home = home;
            _name = name; 
        }

        public void DoorOpen(){
            if(this.IsValidAccess()){
                this._home.DoorOpen();
            }
            else{
                Console.WriteLine("Invalid authentication");
            }
        }
        public bool IsValidAccess(){
            if(_name.Equals("haris")){
                return true;
            }
            return false;
        }
    }
}