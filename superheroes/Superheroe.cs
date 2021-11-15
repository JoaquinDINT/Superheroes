using System.Collections.Generic;
using System.ComponentModel;

namespace superheroes
{
    public class Superheroe : INotifyPropertyChanged
    {

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set
            { 
                if (this._nombre != value)
                {
                    _nombre = value;
                    this.NotifyPropertyChanged("Nombre");
                }     
            }
        }

        private string _imagen;

        public string Imagen
        {
            get { return _imagen; }
            set
            {
                if (this._imagen != value)
                {
                    _imagen = value;
                    this.NotifyPropertyChanged("Imagen");
                }
            }
        }

        private bool _vengador;

        public bool Vengador
        {
            get { return _vengador; }
            set
            {
                if (this._vengador != value)
                {
                    _vengador = value;
                    this.NotifyPropertyChanged("Vengador");
                }
            }
        }

        private bool _xmen;

        public bool Xmen
        {
            get { return _xmen; }
            set
            {
                if (this._xmen != value)
                {
                    _xmen = value;
                    this.NotifyPropertyChanged("Xmen");
                }
            }
        }

        private bool _heroe;

        public bool Heroe
        {
            get { return _heroe; }
            set
            {
                if (this._heroe != value)
                {
                    _heroe = value;
                    this.NotifyPropertyChanged("Heroe");
                }
            }
        }

        public Superheroe()
        {
        }

        public Superheroe(string nombre, string imagen, bool vengador, bool xmen, bool heroe)
        {
            Nombre = nombre;
            Imagen = imagen;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public static List<Superheroe> GetSamples()
        {
            List<Superheroe> ejemplos = new List<Superheroe>();

            Superheroe ironman = new Superheroe("Ironman", @"https://dossierinteractivo.com/wp-content/uploads/2021/01/Iron-Man.png", true, false, true);
            Superheroe kingpin = new Superheroe("Kingpin", @"https://www.comicbasics.com/wp-content/uploads/2017/09/Kingpin.jpg", false, false, false);
            Superheroe spiderman = new Superheroe("Spiderman", @"https://wipy.tv/wp-content/uploads/2019/08/destino-de-%E2%80%98Spider-Man%E2%80%99-en-los-Comics.jpg", true, true, true);

            ejemplos.Add(ironman);
            ejemplos.Add(kingpin);
            ejemplos.Add(spiderman);

            return ejemplos;
        }
    }
}