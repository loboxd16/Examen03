using Examen03.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Examen03.ViewModel
{
    public class ViewModelListarProductos : ViewModelBase
    {
        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set
            {
                _Nombre = value;
                OnPropertyChanged(nameof(Nombre));
            }
        }

        private string _Descripcion;

        public string Descripcion
        {
            get { return _Descripcion; }
            set
            {
                _Descripcion = value;
                OnPropertyChanged(nameof(Descripcion));

            }


        }
        private double _Precio;

        public double Precio
        {
            get { return _Precio; }
            set
            {
                _Precio = value;
                OnPropertyChanged(nameof(Precio));
            }
        }

        private String _final;

        public String Final

        { get { return _final; }
            set {
                _final = value;
                OnPropertyChanged(nameof(Final));  
                  
}
        }
        

        public ObservableCollection<Producto> Productos { get; }
       
        public ICommand GuardarCommand {  get; }

        public ViewModelListarProductos()
        {
            GuardarCommand = new RelayCommand(Guardar);
            Productos=new ObservableCollection<Producto>();


        }
        private void Guardar()
        {
            Final = string.Concat(Nombre, "", Descripcion, "", Precio, "");

            Productos.Add(new Producto()
            {
                Nombre = Nombre,
                Descripcion = Descripcion,
                Precio = Precio,

            });
        
        }


    }
}