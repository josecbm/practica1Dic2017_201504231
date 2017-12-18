using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1edd
{
    class nodolista{
        String usuario;
        String pass;
        nodolista siguiente;
        nodolista anterior;
        pila pila = new pila();
        cola_ cola = new cola_();
        public nodolista(String usuario , String pass)
        {
            this.usuario = usuario;
            this.pass = pass;
            this.siguiente = null;
            this.anterior = null;
        }
        public String getUsuario()
        {
            return this.usuario;
        }
        public pila getPila()
        {
            return this.pila;
        }
        public cola_ getCola()
        {
            return this.cola;
        }
        public String getPass()
        {
            return this.pass;
        }
        public void setSiguiente(nodolista nodo)
        {
            this.siguiente = nodo;
        }
        public nodolista getSiguiente()
        {
            return this.siguiente;
        }
        public void setAnterior(nodolista nodo)
        {
            this.anterior = nodo;
        }
        public nodolista getAnterior()
        {
            return this.anterior;
        }
    }
    class lista_dob_enlazada
    {
        nodolista cabeza;
        String archivo;
        String pri;
        nodolista nuevoNodo;
        nodolista nodoTemporal;
        nodolista temporal;
        public lista_dob_enlazada() {
            this.cabeza = null;
        }
        public bool agregar(String usuario , String pass) {


            nuevoNodo = new nodolista(usuario, pass);
            if (this.cabeza == null)
            {
                nuevoNodo.setSiguiente(nuevoNodo);
                nuevoNodo.setAnterior(nuevoNodo);
                this.cabeza = nuevoNodo;

            }
            else
            {
                nodoTemporal = this.cabeza.getAnterior();

                this.cabeza.setAnterior(nuevoNodo);
                nuevoNodo.setAnterior(nodoTemporal);
                nuevoNodo.setSiguiente(this.cabeza);
                nodoTemporal.setSiguiente(nuevoNodo);
            }
            
            return true;
        }
        public void recorrerUsuarios()
        {
            temporal = this.cabeza.getAnterior();
            archivo += this.cabeza.getUsuario();
            while (temporal != this.cabeza)
            {
                archivo += "->"+temporal.getUsuario();
                temporal = temporal.getAnterior();
            }
            Grafica gra = new Grafica();
            gra.textoLista(archivo);
            gra.dibujarLista("imagenes\\lista.txt", "C:\\");
            
        }
        public nodolista login(String usuario , String passs)
        {
            temporal = this.cabeza.getAnterior();
            if(this.cabeza.getUsuario().Equals(usuario) && this.cabeza.getPass().Equals(passs))
            {
                return temporal;
            }
            while( temporal!= this.cabeza)
            {
                if (temporal.getUsuario().Equals(usuario) && temporal.getPass().Equals(passs))
                {

                    return temporal;
                }
                temporal = temporal.getAnterior();
            }
            return null;
        }

    }
}
