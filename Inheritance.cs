namespace GettingStarted{
    public class BankTerminal
    {
        protected string id;

        public BankTerminal(string id)
        {
            this.id = id;
        }
        public virtual void Connect(){
            System.Console.WriteLine("general connecting protocol");
        }
        
    }




    public class ModelXTerminal : BankTerminal{

        public ModelXTerminal(string id) : base(id) {}



        public override void Connect(){
            base.Connect();
            System.Console.WriteLine("additional actions for model x connection establishment");

        }
    }


    public class ModelYTerminal : BankTerminal{

        public ModelYTerminal(string id) : base(id) {}

        public override void Connect(){
            System.Console.WriteLine("additional actions for model y connection establishment");

        }
    }


}