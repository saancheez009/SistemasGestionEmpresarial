using System.ComponentModel.DataAnnotations;

namespace Ejercicio3U8.Models
{
    public class clsPersona
    {
        private int id;

        private string name;

        private string lastname;

        private int age;

        public clsPersona()
        {
            id = 0;
            name = "";
            lastname = "";
            age = 0;
        }

        public clsPersona(int id, string name, string lastname, int age)
        {
            this.id = id;
            this.name = name;
            this.lastname = lastname;
            this.age = age;
        }

        public int Id
        {
            get { return id; }
        }


        [Required(ErrorMessage ="Debe introducir el nombre"), 
         DataType(DataType.Text),
         MaxLength(15)]
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        [Required(ErrorMessage = "Debe introducir el nombre"),
         DataType(DataType.Text),
         MaxLength(15)]
        public string Lastname 
        { 
            get { return lastname; } 
            set {  lastname = value; } 
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }
}
