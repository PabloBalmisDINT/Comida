using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida
{
    class MainActivityVM : INotifyPropertyChanged
    {
        private ObservableCollection<Plato> listaPlatos;

        public ObservableCollection<Plato> ListaPlatos
        {
            get { return listaPlatos; }
            set 
            { 
                listaPlatos = value;
                NotifyPropertyChanged("ListaPlatos");
            }
        }

        private Plato platoActual;

        public Plato PlatoActual
        {
            get { return platoActual; }
            set 
            { 
                platoActual = value;
                NotifyPropertyChanged("PlatoActual");
            }
        }

        private ObservableCollection<string> tipoComida;
        public ObservableCollection<string> TipoComida
        {
            get { return tipoComida; }
            set
            {
                tipoComida = value;
                NotifyPropertyChanged("TipoComida");
            }
        }

        public MainActivityVM()
        {
            listaPlatos = Plato.GetSamples("./assets");
            tipoComida = new ObservableCollection<string>();
            tipoComida.Add("Americana");
            tipoComida.Add("China");
            tipoComida.Add("Mexicana");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //Metodos
        public void LimpiarActual()
        {
            PlatoActual = null;
        }
    }
}
