using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimTP2Q.Lógica
{
    public class LlamadaMontecarlo
    {
        #region Atributos
        public int hora;
        public int llamada;
        public double rndAtencion;
        public string atiende;
        public double rndQuien;
        public string quien;
        public double rndCompra;
        public string compra;
        public double rndGasto;
        public int gasto;
        public int ingresoAC;
        public double ingresoPorHora;
        #endregion

        #region Getters/Setters
        public int getHora() { return hora; }
        public int getLlamada() { return llamada; }
        public double getRndAtencion() { return rndAtencion; }
        public string getAtiende() { return atiende; }
        public double getRndQuien() { return rndQuien; }
        public string getQuien() { return quien; }
        public double getRndCompra() { return rndCompra;}
        public string getCompra() { return compra; }
        public double getRndGasto() { return rndGasto; }
        public int getGasto() { return gasto; }
        public int getIngresoAC() { return ingresoAC; }
        public double getIngresoPorHora() { return ingresoPorHora; }
        #endregion

        #region Constructor
        public LlamadaMontecarlo(int hora, int llamada,  double rndAtencion, string atiende, double rndQuien, string quien, double rndCompra, string compra,double rndGasto, int gasto, int ingresoAC, double ingresoPorHora)
        {
            this.hora = hora;
            this.llamada = llamada;
            this.rndAtencion = rndAtencion;
            this.atiende = atiende;
            this.rndQuien = rndQuien;
            this.quien = quien;
            this.rndCompra = rndCompra;
            this.compra = compra;
            this.rndGasto = rndGasto;
            this.gasto = gasto;
            this.ingresoAC = ingresoAC;
            this.ingresoPorHora = ingresoPorHora;
        }
        public LlamadaMontecarlo()
        {

        }

        #endregion
    }
}
