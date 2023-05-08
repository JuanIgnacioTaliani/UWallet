using System.IO;
using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace UWallet.Entidades
{
    public class Criptomoneda
    {
        #region Atributos
        private int id;
        private string nombre;
        private string abreviacion;
        private double cantidad;
        private string logo;
        private Image imagen;
        #endregion

        #region Accesores
        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Abreviacion { get { return abreviacion; } set { abreviacion = value; } }
        public double Cantidad { get { return cantidad; } set { cantidad = value; } }
        public string Logo { get { return logo; } set { logo = value; } }
        public Image Image { get { return imagen; } set { imagen = value; } }

        #endregion
        public Criptomoneda() { }
        public Criptomoneda(int id, string abreviacion, double cantidad) 
        {
            this.id = id;
            this.abreviacion = abreviacion;
            this.cantidad = cantidad;
        }
        public Criptomoneda(int id, string nombre, string abreviacion, double cantidad, string logo)
        {
            this.id = id;
            this.nombre = nombre;
            this.abreviacion = abreviacion;
            this.cantidad = cantidad;
            this.logo = logo;
            this.imagen = StringToImage(logo);
        }
        public Criptomoneda(int id,string nombre, string abreviacion, double cantidad, Image imagen)
        {
            this.id = id;
            this.nombre = nombre;
            this.abreviacion = abreviacion;
            this.cantidad = cantidad;
            this.imagen = imagen;
            this.logo = ImageToString(imagen);

        }

        public Criptomoneda(string nombre, string abreviacion, float cantidad, Image imagen)
        {
            this.nombre = nombre;
            this.abreviacion = abreviacion;
            this.cantidad = cantidad;
            this.imagen = imagen;
            this.logo = ImageToString(imagen);

        }
        public bool ValidarNombre() 
        {
            return !(string.IsNullOrEmpty(nombre));
        }

        public bool ValidarAbreviacion() 
        {
            return !(string.IsNullOrEmpty(abreviacion));
        }

        public bool ValidarCantidad() 
        { 
            return cantidad > 0;
        }
        public bool ValidarImagen() 
        {
            return imagen == null;
        }

        public Image StringToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                ms.Write(imageBytes, 0, imageBytes.Length);
                return Image.FromStream(ms, true);
            }
        }
        public string ImageToString(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms,ImageFormat.Png);
                byte[] imageBytes = ms.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }
        public bool IgualNombre(string nombre) { return this.nombre == nombre; }
        public bool IgualAbreviacion(string abreviacion) { return this.abreviacion == abreviacion; }
        public bool IgualImagen(string imagen) { return this.logo == imagen; }
        public bool IgualCantidad(double cantidad) { return this.cantidad == cantidad; }
        public bool EsIgual(Criptomoneda cripto) { return IgualNombre(cripto.Nombre) && IgualAbreviacion(cripto.Abreviacion) && IgualCantidad(cripto.Cantidad) && IgualImagen(cripto.Logo);}
    }
}
