using System;
namespace SpotAPI
{
    public class master
    {
		static int caca;
        public master()
        {
			Console.WriteLine("Eres un pendejo?\n1. Si\n2. No");
			caca = int.Parse(Console.ReadLine());
			if(conditional() == true){
				Console.Clear();
				Console.WriteLine("Eres HIRAM!");
			}
			else{
				Console.Clear();
				Console.WriteLine("Chingon compa.");
			}
        }

		private bool conditional(){
			if(caca == 1 ){
				return true;
			}
			else{
				return false;
			}
		}
    }
}
