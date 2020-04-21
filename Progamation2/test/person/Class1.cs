using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    public class Person
    {
		private string m_name;
		public string Name
		{
			get { return m_name; }
			set { m_name = value; }
		}

		private int m_age;
		public int Age
		{
			get { return m_age; }
			set { m_age = value; }
		}

		public Person()
		{
			Console.WriteLine("Nouvelle personne créée.");
		}

		public Person(string name, int age)
		{
			this.m_age = age;
			this.m_name = name;
			Console.WriteLine("Nouvelle personne créée. Cette personne s'appelle " + name + " et a " + age + " an(s).");
		}

		~Person()
		{
			Console.WriteLine("Objet détruit.");
		}

		public void SayHi()
		{
			Console.WriteLine("Bonjour ! Je m'appelle " + this.m_name + " et j'ai " + this.m_age + " ans.");
		}
	}
}
