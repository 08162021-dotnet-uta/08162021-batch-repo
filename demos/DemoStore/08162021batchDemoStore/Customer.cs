namespace _08162021batchDemoStore
{
    internal class Customer
    {
        private string fname;
        public string Fname
        {
            get
            {
                return this.fname;
            }
            set
            {
                if (value.Length > 50 || value.Length == 0)
                {
                    this.fname = "invalid Name Input";
                }
                else
                {
                    this.fname = value;
                }
            }
        }
        public string Lname { get; set; }

        public Customer() { }

        public Customer(string fname, string lname)
        {
            this.Fname = fname;
            this.Lname = lname;
        }


    }//EoC
}//EoN