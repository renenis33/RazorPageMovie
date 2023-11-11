using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations.Schema;


namespace RazorPageMovie.Models
{
    public class Movie
    {

        public int Id { get; set; }

        //El simbolo "?" despues del tipo de dato habilita la opcion que el valor este vacio

        public string? Title { get; set; }
        /// <summary>
        /// [DataType] se usa para crear una etiqueta
        /// 
        ///Las etiquetas se utilizan para dar un formato especifico 
        /// </summary>
        [DataType(DataType.Date)]

        public DateTime RealeseDate { get; set; }

        public string? Genre { get; set; }
        [Column(TypeName = "decimal(18,2)")]

        public double? Price { get; set; }



    }
}
