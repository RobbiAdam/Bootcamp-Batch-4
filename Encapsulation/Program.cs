using PrivateLibrary;
	
	class Program
	{
		static void Main()
		{
		
			// Data fahmi =  new Data(12000, "Fahmi Hidayat", 24);
			// Console.WriteLine(fahmi.GetSallary());
			PrivateData data = new PrivateData("Fahmi ", 24, "Salatiga");
			
			Console.WriteLine(data.GetName());
			Console.WriteLine(data.SetName("Hidayat")); // output : True
			Console.WriteLine(data.GetName());	//after set
		}
	}
	
	
class Data
	{
		private int _sallary;
		private string _name;
		private int _age;
		
		public Data (int sallary, string name, int age)
		{
			_name = name;
			_sallary = sallary;
			_age = age;
		}
		public int  GetSallary()
		{
			return _sallary;
		}
		
		public string GetName()
		{
			return _name;
		}
		
		public int getAge()
		{
			return _age;
		}
	}