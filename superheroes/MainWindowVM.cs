using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superheroes
{
    class MainWindowVM: INotifyPropertyChanged
    {


        private Superheroe _superheroeActual;

        public Superheroe SuperheroeActual
        {
            get { return _superheroeActual; }
            set {
                if (this._superheroeActual != value)
                {
                    _superheroeActual = value;
                    this.NotifyPropertyChanged("SuperheroeActual");
                }
            }
        }

        private string _contadorActual;

        public string ContadorActual
        {
            get { return _contadorActual; }
            set 
            {
                if (this._contadorActual != value)
                {
                    _contadorActual = value;
                    this.NotifyPropertyChanged("ContadorActual");
                }
            }
        }



        private int contador = 0;
        private readonly List<Superheroe> listaHeroes;


        public MainWindowVM()
        {
            listaHeroes = Superheroe.GetSamples();
            SuperheroeActual = listaHeroes[0];
            ContadorActual = "1/3";
        }

        public void Avanza()
        {
            if (contador < 2)
            {
                contador++;
                SuperheroeActual = listaHeroes[contador];
                ContadorActual = (contador + 1).ToString() + "/3";
            }
        }

        public void Retrocede()
        {
            if (contador > 0)
            {
                contador--;
                SuperheroeActual = listaHeroes[contador];
                ContadorActual = (contador + 1).ToString() + "/3";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
